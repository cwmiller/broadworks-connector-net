using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemDeviceManagementTagSetRegionTagGetListRequest.
    /// The column headings for the tagsTable are: "Tag Name", "Tag Value".
    /// <see cref="SystemDeviceManagementTagSetRegionTagGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:8589""}]")]
    public class SystemDeviceManagementTagSetRegionTagGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _tagsTable;

        [XmlElement(ElementName = "tagsTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:8589")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TagsTable
        {
            get => _tagsTable;
            set
            {
                TagsTableSpecified = true;
                _tagsTable = value;
            }
        }

        [XmlIgnore]
        protected bool TagsTableSpecified { get; set; }

    }
}
