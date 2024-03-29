using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementTagSetGetListRequest22.
    /// The response includes a table of tag set names defined in the system.
    /// Column headings are: "Tag Set Name", "Reseller Id".
    /// 
    /// The following columns are only returned in AS data mode:
    /// "Reseller Id"
    /// The system default tag set name is not part of this response.
    /// <see cref="SystemDeviceManagementTagSetGetListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8353""}]")]
    public class SystemDeviceManagementTagSetGetListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _tagSetTable;

        [XmlElement(ElementName = "tagSetTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8353")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TagSetTable
        {
            get => _tagSetTable;
            set
            {
                TagSetTableSpecified = true;
                _tagSetTable = value;
            }
        }

        [XmlIgnore]
        protected bool TagSetTableSpecified { get; set; }

    }
}
