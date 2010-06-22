using System.Collections.Generic;

namespace EduEva.CoreData
{
    public class ReasonsForTesting
    {
        private List<string> ExistingReasons { get; set; }

        public ReasonsForTesting()
        {
            ExistingReasons = new List<string>();
        }

        public void AddReason(string reason)
        {
            if (ExistingReasons.Contains(reason)) return;
            ExistingReasons.Add(reason);
        }

        public List<string> GetReasons()
        {
            return ExistingReasons;
        }
    }
}
