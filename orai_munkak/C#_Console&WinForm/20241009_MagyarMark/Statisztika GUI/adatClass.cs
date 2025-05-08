using System;
using System.Linq;
class data
        {
            public int playerID;
            public string[] types = new string[3];
            public int[] scores = new int[3];
            public int[] Realscores = new int[3];
            public int circlescores;
            public data(string sor)
            {
                string[] strings = sor.Split(';');
                try
                {
                    this.playerID = int.Parse(strings[0]);
                    for (int i = 1; i < 4; i++)
                    {
                        if (strings[i][0] == 'D' || strings[i][0] == 'T' || strings[i][0] == 'B')
                        {
                            this.types[i - 1] = strings[i][0].ToString();
                            if (strings[i][0] == 'D')
                            {
                                this.scores[i - 1] = int.Parse(strings[i].Substring(1));
                                this.Realscores[i - 1] = int.Parse(strings[i].Substring(1))*2;
                            }
                            else if (strings[i][0] == 'T')
                            {
                                this.scores[i - 1] = int.Parse(strings[i].Substring(1));
                                this.Realscores[i - 1] = int.Parse(strings[i].Substring(1))*3;
                            }
                            else
                            {
                                this.scores[i - 1] = 50;
                                this.Realscores[i - 1] = 50;
                            }
                        }
                        else
                        {
                            this.types[i - 1] = "";
                            this.scores[i - 1] = int.Parse(strings[i]);
                            this.Realscores[i - 1] = int.Parse(strings[i]);
                        }
                    }
                    this.circlescores = Realscores.Sum();
                }
                catch (Exception)
                {
                    this.playerID = -99;
                }
            }
        }