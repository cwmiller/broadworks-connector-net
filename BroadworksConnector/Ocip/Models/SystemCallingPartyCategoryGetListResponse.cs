using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallingPartyCategoryGetListRequest.
    /// Contains a table of Calling Party Category defined in system.
    /// The column headings are: "Category Name", "User Category", "Collect Call", "Default" and "Web Display Key".
    /// <see cref="SystemCallingPartyCategoryGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""89aa8c9a341a3cccb2453b1ee467bf94:104""}]")]
    public class SystemCallingPartyCategoryGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _callingPartyCategoryTable;

        [XmlElement(ElementName = "callingPartyCategoryTable", IsNullable = false, Namespace = "")]
        [Group(@"89aa8c9a341a3cccb2453b1ee467bf94:104")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallingPartyCategoryTable
        {
            get => _callingPartyCategoryTable;
            set
            {
                CallingPartyCategoryTableSpecified = true;
                _callingPartyCategoryTable = value;
            }
        }

        [XmlIgnore]
        public bool CallingPartyCategoryTableSpecified { get; set; }

    }
}
