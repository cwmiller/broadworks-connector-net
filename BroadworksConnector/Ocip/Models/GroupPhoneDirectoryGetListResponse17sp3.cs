using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPhoneDirectoryGetListRequest17sp3.
    /// Contains a table with a row for each phone number and column headings :
    /// "Name", "Number", "Extension", "Mobile", "Email Address",
    /// "Department", "Hiragana Name", "Group Id", "Yahoo Id", "IMP Id" and
    /// "Is Virtual On-Net User"
    /// If extended directory information is requested, the following columns are also included:
    /// "First Name", "Last Name", "User Id", "Pager", "Title", "Time Zone",
    /// "Location", "Address Line 1", "Address Line 2", "City", "State",
    /// "Zip", "Country".
    /// 
    /// Replaced by: GroupPhoneDirectoryGetListResponse18
    /// <see cref="GroupPhoneDirectoryGetListRequest17sp3"/>
    /// <see cref="GroupPhoneDirectoryGetListResponse18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:12033""}]")]
    public class GroupPhoneDirectoryGetListResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _directoryTable;

        [XmlElement(ElementName = "directoryTable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12033")]
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
