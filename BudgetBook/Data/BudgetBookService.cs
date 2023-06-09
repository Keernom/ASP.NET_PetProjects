﻿namespace BudgetBook.Data
{
    public class BudgetBookService
    {
        private static List<Entry> mockDb = new List<Entry>();

        public async Task<bool> AddEntry(Entry entry)
        {
            mockDb.Add(entry);
            return true;
        }

        public async Task<List<Entry>> GetAllEntries()
        {
            return mockDb;
        }
    }
}
