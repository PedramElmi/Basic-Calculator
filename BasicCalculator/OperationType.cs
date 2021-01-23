namespace BasicCalculator
{
    /// <summary>
    /// The basic operation types. it is currently not needed to use this class.
    /// </summary>
    public static class OperationType
    {
        #region fields

        private static string add = "+";
        private static string minus = "-";
        private static string divide = "/";
        private static string multiply = "*";

        #endregion

        #region Properties

        /// <summary>
        /// Add Two Numbers (sum)
        /// </summary>
        public static string Add
        {
            get
            {
                return add;
            }
        }

        /// <summary>
        /// Differentiate two numbers
        /// </summary>
        public static string Minus
        {
            get
            {
                return minus;
            }
        }

        /// <summary>
        /// Divide two numbers
        /// </summary>
        public static string Divide
        {
            get
            {
                return divide;
            }
        }

        /// <summary>
        /// Multiply two numbers
        /// </summary>
        public static string Multiply
        {
            get
            {
                return multiply;
            }
        }

        #endregion

    }



}
