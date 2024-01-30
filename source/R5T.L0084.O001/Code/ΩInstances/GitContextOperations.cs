using System;


namespace R5T.L0084.O001
{
    public class GitContextOperations : IGitContextOperations
    {
        #region Infrastructure

        public static IGitContextOperations Instance { get; } = new GitContextOperations();


        private GitContextOperations()
        {
        }

        #endregion
    }
}
