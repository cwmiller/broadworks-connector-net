using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterprisePhoneDirectoryGetListRequest17.
    /// Contains a table with  a row for each phone number and column headings :
    /// "Name", "Number", "Extension", "Mobile", "Email Address",
    /// "Department", "Hiragana Name", "Group Id", "Yahoo Id", "Is Virtual On-Net User".
    /// If extended directory information is requested, the following columns are also included:
    /// "First Name", "Last Name", "User Id", "Pager", "Title", "Time Zone",
    /// "Location", "Address Line 1", "Address Line 2",
    /// "City", "State", "Zip", "Country".
    /// 
    /// Replaced by: EnterprisePhoneDirectoryGetListResponse18
    /// <see cref="EnterprisePhoneDirectoryGetListRequest17"/>
    /// <see cref="EnterprisePhoneDirectoryGetListResponse18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:2520""}]")]
    public class EnterprisePhoneDirectoryGetListResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:2520")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DirectoryTable
        {
            get => _directoryTable;
            set
            {
                DirectoryTableSpecified = true;
                _directoryTable = value;
            }
        }

        [XmlIgnore]
        protected bool DirectoryTableSpecified { get; set; }

    }
}
