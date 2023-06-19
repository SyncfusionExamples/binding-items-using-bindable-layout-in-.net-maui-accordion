using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccordionBindableLayout
{
    public class EmployeeInfo : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private string image;
        private string position;
        private string organizationunit;
        private string dateofbirth;
        private string location;
        private string phone;
        private bool isexpanded;
        private string description;

        #endregion

        #region Constructor

        public EmployeeInfo(string name, string image, string position, string organizationunit, string dateofbirth, string location, string phone, bool isexpanded, string description)
        {
            Name = name;
            Image = image;
            Position = position;
            OrganizationUnit = organizationunit;
            DateOfBirth = dateofbirth;
            Location = location;
            Phone = phone;
            IsExpanded = isexpanded;
            Description = description;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged("Image"); }
        }

        public string Position
        {
            get { return position; }
            set { position = value; OnPropertyChanged("Position"); }
        }

        public string OrganizationUnit
        {
            get { return organizationunit; }
            set { organizationunit = value; OnPropertyChanged("OrganizationUnit"); }
        }

        public string DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; OnPropertyChanged("DateOfBirth"); }
        }

        public string Location
        {
            get { return location; }
            set
            {
                location = value; OnPropertyChanged("DateOfBirth");
            }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged("Phone"); }
        }

        public bool IsExpanded
        {
            get { return isexpanded; }
            set { isexpanded = value; OnPropertyChanged("IsExpanded"); }
        }

        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged("Description"); }
        }


        #endregion

        #region Interface Member

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
