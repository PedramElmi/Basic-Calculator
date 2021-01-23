using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    public class Operation
    {

        #region Public Properties

        /// <summary>
        /// the left side of the operation
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// the right side of the operation. it is currently not needed to use this class.
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// the type of operation to perform
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// the inner operation to be performed initially before this operation
        /// </summary>
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Operation()
        {
            // create empty string instead of empty nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }

        #endregion
    }
}
