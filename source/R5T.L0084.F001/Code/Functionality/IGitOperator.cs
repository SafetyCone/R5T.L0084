using System;

using R5T.T0132;


namespace R5T.L0084.F001
{
    [FunctionalityMarker]
    public partial interface IGitOperator : IFunctionalityMarker
    {
        public string Clone_NonIdempotent(
            string sourceUrl,
            string localRepositoryDirectoryPath,
            string username,
            string password)
        {
            return Instances.LibGit2SharpOperator.Clone_NonIdempotent(
                sourceUrl,
                localRepositoryDirectoryPath,
                username,
                password);
        }

        public bool Push_Changes(
            string repositoryDirectoryPath,
            string commitMessage,
            string authorName,
            string authorEmailAddress,
            string username,
            string password)
        {
            var output = Instances.LibGit2SharpOperator.Push_Changes(
                repositoryDirectoryPath,
                commitMessage,
                authorName,
                authorEmailAddress,
                username,
                password);

            return output;
        }
    }
}
