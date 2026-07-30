using System;
using System.Data;

namespace EZMenu.Data
{
    // Initial data access wrapper. We'll port typed DataSet usage here in discovery phase.
    public interface IDatabaseService
    {
        DataSet ExecuteDataSet(string commandText);
    }

    public class DatabaseService : IDatabaseService
    {
        public DataSet ExecuteDataSet(string commandText)
        {
            // Temporary stub: original VB used typed DataSets. We'll port logic from EZMenuDataSet.Designer.vb later.
            return new DataSet();
        }
    }
}
