using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccordionBindableLayout
{
    public class EmployeeDetails
    {
        #region Fields

        private ObservableCollection<EmployeeInfo>? _employee;

        string[] Description = new string[]
        {
        "Robin Rane, Chairman of ABC Inc., leads with dedication and vision.Under his guidance, the company thrives and continues to make a significant impact in the industry.",
        "Paul Vent, General Manager of XYZ Corp., oversees daily operations, ensuring the company's success and growth through strategic planning and effective management practices.",
        "Clara Venus, Asst. Manager at ABC Inc., efficiently handles multiple tasks. With her strong skill set and dedication, she contributes significantly to the company's growth and success.",
        "Maria Even, a highly experienced professional, holds the position of Executive Manager at XYZ Corp. She oversees crucial operations, enforcing company policies and practices."
        };

        #endregion

        #region Constructor

        public EmployeeDetails()
        {
            Employees = new ObservableCollection<EmployeeInfo>();
            Employees.Add(new EmployeeInfo("Robin Rane", "emp_01.png", "Chairman", "ABC Inc.", "09/17/1973", "Boston", "(617) 555-1234", false, Description[0]));
            Employees.Add(new EmployeeInfo("Paul Vent", "emp_02.png", "General Manager", "XYZ Corp.", "05/27/1985", "New York", "(212) 555-1234", true, Description[1]));
            Employees.Add(new EmployeeInfo("Clara Venus", "emp_03.png", "Assistant Manager", "ABC Inc.", "07/22/1988", "California", "(415) 123-4567", false, Description[2]));
            Employees.Add(new EmployeeInfo("Maria Even", "emp_04.png", "Executive Manager", "XYZ Corp.", "04/16/1970", "New York", "(516) 345-6789", false, Description[3]));
        }

        #endregion

        #region Properties

        public ObservableCollection<EmployeeInfo>? Employees
        {
            get { return _employee; }
            set { _employee = value; }
        }

        #endregion
    }
}
