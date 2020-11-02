using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operation
    {
        #region Public fields for parameters
        /// <summary>
        /// Left Side of the operation we performed
        /// </summary>
        public string LeftSide { get; set; }

        /// <summary>
        /// Right Side of the operation we performed
        /// </summary>        
        public string RightSide { get; set; }

        /// <summary>
        /// Type of the operation we performed
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Type of the operation we performed
        /// </summary>
        public OperationType AfterDotType { get; set; }

        /// <summary>
        /// Iner operation of the operation we performed to be performed before
        /// </summary>
        public OperationType InerOperation { get; set; }
        #endregion

        #region Constructor
        public Operation()
        {
            // Create empty strings instead of having nulls
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        #endregion
    }
}
