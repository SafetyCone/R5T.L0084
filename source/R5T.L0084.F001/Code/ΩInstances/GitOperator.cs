using System;


namespace R5T.L0084.F001
{
    public class GitOperator : IGitOperator
    {
        #region Infrastructure

        public static IGitOperator Instance { get; } = new GitOperator();


        private GitOperator()
        {
        }

        #endregion
    }
}
