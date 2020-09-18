using System;
using System.Diagnostics;

namespace TestWeb.Domain.ExceptionHandlers
{
    /// <summary>
    /// Static class for debug
    /// </summary>
    public static class ExceptionMessage
    {
        /// <summary>
        /// Shows debug message
        /// </summary>
        /// <param name="repoName"> Repository name </param>
        /// <param name="methodName"> Method name </param>
        /// <param name="ex"> An exception which may occur </param>
        public static void ShowMessage(string repoName, string methodName, Exception ex) =>
            Debug.WriteLine($"{repoName}: Something is wrong with the \'{methodName}\' method. \nError: {ex.Message}");
    }
}
