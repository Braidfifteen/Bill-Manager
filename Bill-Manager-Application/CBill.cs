using System;

namespace Password_Manager_Application
{
    [Serializable()]
    class CBill
    {
        #region Fields

        private string name;
        private double totalAmountOwed;
        private double monthlyAmountOwed;
        private DateTime monthlyDueDate;
        bool isPayedForMonth;

        #endregion "Fields"

        #region Constructors

        public CBill(string name, double totalAmount, double monthlyOwed, DateTime monthlyDue)
        {
            this.name = name;
            totalAmountOwed = totalAmount;
            monthlyAmountOwed = monthlyOwed;
            monthlyDueDate = monthlyDue;
        }

        #endregion "Constructors"

        #region Properties 

        public string Name { get { return name; } }
        public double TotalAmountOwed { get { return totalAmountOwed; } }
        public double MonthlyAmountOwed { get { return monthlyAmountOwed; } }
        public DateTime MonthlyDueDate { get { return monthlyDueDate; } }
        public bool IsPayedForMonth { get { return isPayedForMonth; } }

        #endregion "Properties"
    }
}
