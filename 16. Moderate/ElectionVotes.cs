using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._16._Moderate
{
    public class ElectionVotes
    {
        public static string GetHightestVoteCandidate(List<Vote> votes, DateTime timeStamp)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (Vote vote in votes)
            {
                if (vote.TimeStamp <= timeStamp)
                {
                    if (!dictionary.ContainsKey(vote.Name))
                    {
                        dictionary.Add(vote.Name, 1);
                    }
                    else
                    {
                        int occurence = dictionary[vote.Name];
                        dictionary[vote.Name] = occurence + 1;
                    }
                }
            }

            int maxVote = 0;
            string maxVoteCandidate = "";
            foreach (var kv in dictionary)
            {
                if (kv.Value == maxVote)
                {
                    maxVoteCandidate = "Tie, No Result";
                }

                if (kv.Value > maxVote)
                {
                    maxVote = kv.Value;
                    maxVoteCandidate = kv.Key;
                }
            }
            return maxVoteCandidate;
        }
    }

    public class Vote
    {
        public string Name { get; set; }
        public DateTime TimeStamp { get; set; }

        public Vote(string name, DateTime dateTime)
        {
            this.Name = name;
            this.TimeStamp = dateTime;
        }
    }
}
