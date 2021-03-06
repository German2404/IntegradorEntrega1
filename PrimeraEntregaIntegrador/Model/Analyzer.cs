﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Concurrent;
using System.Threading;
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace PrimeraEntregaIntegrador
{
    class Analyzer
    {


        public Dictionary<String, Transaction> transactions;
        public Dictionary<String, Client> clients;
        public SortedSet<String> items;
        public double supportThreshold;
        public double confidenceThreshold;
        public List<Association> APassociations;
        public Dictionary<String, int> MarkovSuggestions;
        public Dictionary<String, String> articles;


        public Analyzer(double supportThreshold, double confidenceThreshold)
        {
            this.supportThreshold = supportThreshold;
            this.confidenceThreshold = confidenceThreshold;
            this.transactions = new Dictionary<string, Transaction>();
            this.clients = new Dictionary<string, Client>();
            this.items = new SortedSet<string>();
            this.articles = new Dictionary<string, string>();
            APassociations = null;
            MarkovSuggestions = null;
        }


        public Dictionary<String,int>getSalesData(String itemCode)
        {
            var sales = transactions.Select(i => i.Value).Where(i => i.items.Contains(itemCode)).GroupBy(i => new { year = i.date.Year, month = i.date.Month }).Select(i=>new {year=i.Key.year, month=i.Key.month,count=i.Count() }).OrderBy(i=>i.year).ThenBy(i=>i.month);
            Dictionary<String, int> returnSales = new Dictionary<string, int>();
            foreach(var sale in sales)
            {
                returnSales.Add(sale.year + "-" + sale.month, sale.count);
            }
            return returnSales;
        }


        public void readTransactions(String[]lines)
        {
            
            
            for (int i = 0; i < lines.Length; i++)
            {
               
                String[] split = lines[i].Split('\t');
                if (!this.articles.ContainsKey(split[3]))
                {
                    this.articles.Add(split[3], split[4]);
                }
                if (transactions.ContainsKey(split[0]))
                {
                    items.Add(split[3]);
                    transactions[split[0]].items.Add(split[3]);
                }
                else
                {
                    if (!clients.ContainsKey(split[1]))
                    {
                        clients.Add(split[1], new Client(split[1], null, null, null, null));
                    }
                    
                    String[] dateSplit = split[2].Split('/');
                    items.Add(split[3]);
                    DateTime date = new DateTime(Int32.Parse(dateSplit[2]), Int32.Parse(dateSplit[1]), Int32.Parse(dateSplit[0]));
                    transactions[split[0]] = new Transaction(split[0], split[1], date, split[3]);
                }
            }
        }

        public void reportMarkov(Dictionary<String,int>sugg,int size)
        {
            
            var sug = sugg.Select(i => new { Item = i.Key, Count = i.Value }).OrderByDescending(i=>i.Count).Take(size);
           
            var app = new Application { Visible = false };
            Workbook wb = app.Workbooks.Add();
            Worksheet ws = app.ActiveSheet;
            ws.Cells[1, 1] = "ItemSet Assotiations.";
            ws.Cells[2, 1] = "Parameters:";
            ws.Cells[3, 1] = "Method Used:";
            ws.Cells[3, 2] = "Markov suggesion aproximation";
            ws.Cells[4, 1] = "Min. Support Threshold:";
            ws.Cells[4, 2] = this.supportThreshold;
            //ws.Range[ws.Cells[4,2],ws.Cells[4,2]].NumberFormat = "###%";

            ws.Cells[5, 1] = "Min. Confidence Threshold:";
            ws.Cells[5, 2] = this.confidenceThreshold;
            ws.Cells[6, 1] = "Recomendation Size:";
            ws.Cells[6, 2] =size;


            ws.Cells[8, 1] = "Item";
            ws.Cells[8, 2] = "Support Count";

            int count = 9;
            foreach (var a in sug)
            {
                ws.Cells[count, 1] = a.Item;
                ws.Cells[count, 2] = a.Count;
          
                count++;
            }
            String timeStamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Analyzer", "report" + "_" + timeStamp);
            String dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Analyzer");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            Console.WriteLine("Saving excel on " + path);
            ws.SaveAs(Filename: path + ".xlsx", FileFormat: XlFileFormat.xlWorkbookDefault);

            app.Application.Quit();
            Process.Start(path + ".xlsx");
            //File.Open(path+".xlsx", FileMode.Open);


        }


        public void reportAP(List<Association> ass)
        {
            Console.WriteLine("Started");
           
            Console.WriteLine("Termino..");
            
                var app = new Application { Visible = false };
                Workbook wb = app.Workbooks.Add();
                Worksheet ws = app.ActiveSheet;
                ws.Cells[1, 1] = "ItemSet Assotiations.";
                ws.Cells[2, 1] = "Parameters:";
                ws.Cells[3, 1] = "Method Used:";
                ws.Cells[3, 2] = "Apriori with transaction prunning";
                ws.Cells[4, 1] = "Min. Support Threshold:";
                ws.Cells[4, 2] = this.supportThreshold;

                ws.Cells[5, 1] = "Min. Confidence Threshold:";
                ws.Cells[5, 2] = this.confidenceThreshold;


                ws.Cells[7, 1] = "Description";
                ws.Cells[7, 2] = "Support Threshold";
                ws.Cells[7, 3] = "Confidence Threshold";
                int count = 8;
                foreach (var asso in ass)
                {
                    ws.Cells[count, 1] = asso.ToString();
                    ws.Cells[count, 2] = asso.support;
                    ws.Cells[count, 3] = asso.confidence;
                    count++;
                }
                String timeStamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                String path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Analyzer", "report" + "_" + timeStamp);
                String dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Analyzer");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                
                Console.WriteLine("Saving excel on " + path);
                ws.SaveAs(Filename:path+".xlsx",FileFormat: XlFileFormat.xlWorkbookDefault);
                
                app.Application.Quit();
            Process.Start(path + ".xlsx");
                //File.Open(path+".xlsx", FileMode.Open);
          
            
        }


        private List<Transaction> prune(int infLimItems, int supLimItems, int infLimClients, int supLimClients)
        {
            var initial = transactions.Select(i => i.Value).Where(i => i.items.Count <= supLimItems && i.items.Count >= infLimItems);
            var grouping = initial.GroupBy(i => i.clientCode).Where(g => g.Count() >= infLimClients && g.Count() <= supLimClients);
            List<Transaction> filtered = new List<Transaction>();
            foreach( var g in grouping)
            {
                foreach( var h in g)
                {
                    filtered.Add(h);
                }

            }
            return filtered;
        }


        private List<Association> generateBruteForceAssotiations(List<Transaction> prunnedTransactions)
        {
            List<Association> answer = new List<Association>();
            String[] items = prunnedTransactions.SelectMany(i => i.items).Distinct().ToArray();
       
            //Console.WriteLine("Refined Items:" + items.Length);
            var powerSet = PowerSetGenerator.FastPowerSet<String>(items);
       
            foreach(String[] c in powerSet)
            {
                String[] difference = items.Except(c).ToArray();
                var auxPowerSet = PowerSetGenerator.FastPowerSet<String>(difference);
                foreach (String[]c2 in auxPowerSet)
                {
                    answer.Add(new Association(new SortedSet<string>(c), new SortedSet<string>(c2)));
                }
            }
            return answer;

        }


        private double calculateAssociationSupport(Association a,List<Transaction>prunnedTransactions)
        {
            String[] union = a.from.Union(a.to).ToArray();
            int cont = 0;
            foreach(Transaction t in prunnedTransactions)
            {
                bool contains = !union.Except(t.items).Any();
                if (contains)
                {
                    cont++;
                }
            }
            return (double)cont / prunnedTransactions.Count;
        }

        private double calculateAssociationConfidence(Association a, List<Transaction> prunnedTransactions)
        {
            String[] union = a.from.Union(a.to).ToArray();
            int cont1 = 0;
            int cont2 = 0;
            foreach(Transaction t in prunnedTransactions)
            {
                bool contains = !union.Except(t.items).Any();
                if (contains)
                {
                    cont1++;
                }
                bool containsX = !a.from.Except(t.items).Any();
                if (containsX)
                {
                    cont2++;
                }
            }
           
            return (double)cont1 / cont2;
        }

        private List<Association> refineAssociations(List<Association> a, List<Transaction> prunnedTransactions)
        {
            List<Association> answer = new List<Association>();
            for (int i = 0; i < a.Count; i++)
            {
                double s = this.calculateAssociationSupport(a[i], prunnedTransactions);
                double c = this.calculateAssociationConfidence(a[i], prunnedTransactions);
                if(s>=this.supportThreshold && c >= this.confidenceThreshold)
                {
                //Console.WriteLine(a[i] + " " + c);
                    answer.Add(a[i]);
                }
            }
            return answer;
        }

        private double calculateItemSetSupport(List<Transaction> transactions, SortedSet<String> itemSet)
        {
            double count = 0;
            foreach (Transaction t in transactions)
            {
                if (itemSet.IsSubsetOf(t.items))
                {
                    //Console.WriteLine("{" + String.Join(",", itemSet) + "}-->{" + string.Join(",", t.getItems()) + "} SI");
                    count++;
                }
                //else
                //{
                //    Console.WriteLine("{" + String.Join(",", itemSet) + "}-->{" + string.Join(",", t.getItems()) + "} NO");
                //}
            }
            return count / transactions.Count;
        }

        public List<Association>giveBruteForceRefinedAssotiations(int infLimItems, int supLimItems, int infLimClients, int supLimClients)
        {
            var list = this.prune(infLimItems, supLimItems, infLimClients, supLimClients);
            //Console.WriteLine("Total transactions:" + this.transactions.Count);
            //Console.WriteLine("Total items:" + this.items.Count);
            //Console.WriteLine("Refined transactions:" + list.Count);
            var a = this.generateBruteForceAssotiations(list);
            return this.refineAssociations(a, list);
        }


        private List<SortedSet<String>> giveAPrioriFrequentItemsSets(int infLimItems, int supLimItems, int infLimClients, int supLimClients,List<Transaction> transactions)
        {

            String[] items = transactions.SelectMany(i => i.items).Distinct().ToArray();
            //Console.WriteLine("Total items:" + this.items.Count);
            //Console.WriteLine("Refined items:" + items.Length);
            //Console.WriteLine("Nivel de arbol:" + 1);
            List<SortedSet<String>> infrequentItemSets = new List<SortedSet<string>>();

            var frequentItemsSets = new List<SortedSet<String>>();
            List<SortedSet<String>> lastLevel = new List<SortedSet<String>>();

            String[] itemsSku = items;

            ConcurrentBag<SortedSet<String>> unfrequentBag = new ConcurrentBag<SortedSet<string>>();
            ConcurrentBag<SortedSet<String>> frequentBag = new ConcurrentBag<SortedSet<string>>();
            ConcurrentBag<SortedSet<String>> actualBag = new ConcurrentBag<SortedSet<string>>();
            Parallel.For(0, itemsSku.Length, i =>
            {

                SortedSet<String> hash = new SortedSet<string>();
                hash.Add(itemsSku[i]);


                double count = calculateItemSetSupport(transactions, hash);
              
                if (count < this.supportThreshold)
                {
                    unfrequentBag.Add(hash);
                }
                else
                {

                    frequentBag.Add(hash);
                    actualBag.Add(hash);
                }
            });
            infrequentItemSets.AddRange(unfrequentBag);
            frequentItemsSets.AddRange(frequentBag);
            lastLevel.AddRange(actualBag);

            //for (int i = 0; i < itemsSku.Length; i++)
            //{
            //    SortedSet<String> hash = new SortedSet<string>();
            //    hash.Add(itemsSku[i]);


            //    double count = supportCount(transactions, hash);

            //    if (count < st)
            //    {
            //        infrequentItemSets.Add(hash);
            //    }
            //    else
            //    {

            //        frequentItemsSets.Add(hash);
            //        lastLevel.Add(hash);
            //    }
            //}

            //Console.WriteLine("Frequent itemsSet count at level {0}:{1}", 1, frequentItemsSets.Count);
            List<SortedSet<String>> actual = new List<SortedSet<string>>();
            for (int i = 0; i < lastLevel.Count; i++)
            {
                for (int j = i + 1; j < lastLevel.Count; j++)
                {
                    SortedSet<String> set = new SortedSet<string>(lastLevel[i].Union(lastLevel[j]));
                    double sp = calculateItemSetSupport(transactions, set);
                    if (sp < this.supportThreshold)
                    {
                        infrequentItemSets.Add(set);
                    }
                    else
                    {
                        actual.Add(set);
                        frequentItemsSets.Add(set);


                    }
                }
            }
            //Console.WriteLine("Frequent itemsSet count at level {0}:{1}", 2, frequentItemsSets.Count);
            lastLevel = actual;





            for (int i = 3; i <= items.Length; i++)
            {

                List<SortedSet<String>> actualLevel = new List<SortedSet<string>>();
                //Console.WriteLine("Nivel de arbol:" + i);
                for (int j = 0; j < lastLevel.Count; j++)
                {
                    for (int k = j + 1; k < lastLevel.Count; k++)
                    {
                        if (lastLevel[k].Take(lastLevel[k].Count - 1).SequenceEqual(lastLevel[j].Take(lastLevel[j].Count - 1)) && !lastLevel[k].ElementAt(lastLevel[k].Count - 1).Equals(lastLevel[j].ElementAt(lastLevel[j].Count - 1)))
                        {
                            SortedSet<String> candidate = new SortedSet<String>(lastLevel[k].Union(lastLevel[j]));

                            //Console.WriteLine(!infrequentItemSets.Any(inf => { Console.WriteLine("{" + String.Join(",", candidate) + "}-->{" + string.Join(",", inf) + "}"); return candidate.IsSupersetOf(inf); }));

                            if (candidate.Count == i && !infrequentItemSets.Any(inf => candidate.IsSupersetOf(inf)) && calculateItemSetSupport(transactions, candidate) >= this.supportThreshold)
                            {

                                frequentItemsSets.Add(candidate);
                                actualLevel.Add(candidate);
                            }
                            else
                            {
                                infrequentItemSets.Add(candidate);
                            }
                        }



                    }
                }
                lastLevel = actualLevel;
                //Console.WriteLine("Frequent itemsSet count at level {0}:{1}", i, frequentItemsSets.Count);

            }

            return frequentItemsSets;
        }

        public List<Association>apriori2(int infLimItems, int supLimItems, int infLimClients, int supLimClients)
        {
            var prunnedTransactions = this.prune(infLimItems, supLimItems, infLimClients, supLimClients);
            //Console.WriteLine("Transacciones refinadas:" + prunnedTransactions.Count);
            var fItemSets = this.giveAPrioriFrequentItemsSets(infLimItems, supLimItems, infLimClients, supLimClients, prunnedTransactions);
            
            foreach (var itemset in fItemSets)
            {
                List<Association[]> niveles = new List<Association[]>();
                List<Association> originales = new List<Association>();
                for (int i = 0; i < itemset.Count; i++)
                {
                    String[] item = new String[] { itemset.ElementAt(i) };
                    Association a = new Association(new SortedSet<string>(itemset.Except(item)), new SortedSet<String>(item));
                    double c = this.calculateAssociationConfidence(a, prunnedTransactions);

                    if (c >= this.confidenceThreshold)
                    {

                        originales.Add(a);
                    }
                    
                }
                niveles.Add(originales.ToArray());
                int nivelActual = 0;
                while (nivelActual<itemset.Count-1)
                {
                    for (int i = 0; i < 0; i++)
                    {

                    }
                }
            }
            return null;
        }


        public List<Association> giveAPrioriRefinedAssotiations(int infLimItems, int supLimItems, int infLimClients, int supLimClients)
        {
            Console.WriteLine("Transacciones totales:" + this.transactions.Count);
            var prunnedTransactions = this.prune(infLimItems, supLimItems, infLimClients, supLimClients);
            Console.WriteLine("Transacciones refinadas:" + prunnedTransactions.Count);
            var fItemSets = this.giveAPrioriFrequentItemsSets(infLimItems, supLimItems, infLimClients, supLimClients,prunnedTransactions);

            Console.WriteLine("ItemSets generated");

            List<Association> answer = new List<Association>();
            
            for (int i = 0; i < fItemSets.Count; i++)
            {
                List<List<Association>> levels = new List<List<Association>>();
                if (fItemSets[i].Count > 1)
                {
                   
                    var discardedConsecuents = new List<SortedSet<String>>();
                    var lastLevel = new List<Association>();
                    String[] itemSet = fItemSets[i].ToArray();
                    for (int j = 0; j < fItemSets[i].Count; j++)
                    {
                        
                        String[] item = new String[] { fItemSets[i].ElementAt(j) };
                        Association a = new Association(new SortedSet<string>(itemSet.Except(item)), new SortedSet<String>(item));
                        
                        double c = this.calculateAssociationConfidence(a, prunnedTransactions);
                        double s = this.calculateAssociationSupport(a, prunnedTransactions);
                        a.confidence = c;
                        a.support = s;
                        if (c >= this.confidenceThreshold)
                        {
                           
                            answer.Add(a);
                            lastLevel.Add(a);
                        }
                        else
                        {
                            
                            discardedConsecuents.Add(a.to);
                        }
                    }
                    levels.Add(lastLevel);
                    int antecedentLevel = fItemSets[i].Count - 1;
                    int currentLevel = 0;

                    
                    
                 
                    while (antecedentLevel > 1)
                    {
                        List<Association> actualLevel = new List<Association>();

                        
                        for (int k = 0; k < levels[currentLevel].Count ; k++)
                        {
                            for (int z = k; z < levels[currentLevel].Count; z++)
                            {
                               

                                if (k != z)
                                {
                                    //Console.WriteLine(i + " " + k + " " + z);
                                    String[] from1 = levels[currentLevel][k].from.ToArray();
                                    String[] from2 = levels[currentLevel][z].from.ToArray();
                                    String[] to1 = levels[currentLevel][k].to.ToArray();
                                    String[] to2 = levels[currentLevel][z].to.ToArray();
                                    String[] inter = from1.Intersect(from2).ToArray();
                                    
                                    if (inter.Count() > 0)
                                    {
                                        String[] union = to1.Union(to2).ToArray();
                                        //Console.WriteLine("{" + String.Join(",", to1) + "}");
                                        //Console.WriteLine("{" + String.Join(",", to2) + "}");
                                        //Console.WriteLine("{" + String.Join(",", union) + "}"+"\n");
                                        
                                        Association candidate = new Association(new SortedSet<string>(inter), new SortedSet<string>(union));
                                        
                                        if (discardedConsecuents.Any(d => candidate.to.IsSubsetOf(d)))
                                        {
                                            
                                            discardedConsecuents.Add(candidate.to);

                                     
                                        }
                                        else
                                        {
                                            
                                            answer.Add(candidate);
                                           
                                            actualLevel.Add(candidate);
                                            
                                        }
                                    }
                                }
                            }
                        }
                        
                        
                        antecedentLevel--;
                        
                        levels.Add(actualLevel);
                        currentLevel++;
                    }


                }
                
            }

            for (int i = 0; i < answer.Count; i++)
            {
                for (int j = i+1; j < answer.Count; j++)
                {
                    if (answer[i].Equals(answer[j]))
                    {
                        answer.RemoveAt(j);
                        j--;
                        
                    }
                }
            }



            return answer.Where(i=>this.calculateAssociationConfidence(i,prunnedTransactions)>=this.confidenceThreshold).ToList();

        }

        public Dictionary<int, int> generateArticlesTable()
        {
            int max = transactions.Max(i => i.Value.items.Count);
            Dictionary<int, int> retorno = new Dictionary<int, int>();
            for (int i = 1; i <= max; i++)
            {
                retorno[i] = 0;
            }
            foreach (var trans in transactions)
            {
                retorno[trans.Value.items.Count] += 1;

            }
            return retorno;
        }

        public Dictionary<int, int> generateClientsTable()
        {
            List<int> compras = new List<int>();
            foreach (var c in clients)
            {
                int cont = transactions.Where(t => t.Value.clientCode.Equals(c.Value.code)).Count();
                compras.Add(cont);
            }
            
            var com = compras.Where(i => i != 0).GroupBy(i => i).ToDictionary(d => d.Key, d => d.Count());


            return com;
        }

        private Dictionary<String,int> giveMarkovSuggestion(SortedSet<String> items, List<Transaction> trans, int size)
        {
            var list = new List<String>();
            foreach (Transaction t in trans)
            {

                if (items.IsSubsetOf(t.items))
                {
                    var ex = t.items.Except(items);

                    list.AddRange(ex);
                }
            }

            var found = list.Distinct();
            Dictionary<String, int> counting = new Dictionary<string, int>();
            foreach (String s in found)
            {
                counting.Add(s, list.Where(i => i == s).Count());
            }
            var cosa = counting.OrderByDescending(i => i.Value);
            //var taken = cosa.Take(size);
            //foreach (var x in taken)
            //{
            //    Console.WriteLine(x.Key + ":" + x.Value);
            //}
            return counting;
        }

        public Dictionary<String,int> giveMarkovRefinedSuggestion(int infLimItems, int supLimItems, int infLimClients, int supLimClients, int size, SortedSet<String> set)
        {
            var a = this.prune(infLimItems, supLimItems, infLimClients, supLimClients);
            return giveMarkovSuggestion(set,a, size);
        }

    }
}
