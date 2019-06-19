using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderOfficeZoneGetAssignedListRequest.
    /// Contains a table of all Office Zones assigned to the
    /// service provider. The column headings are: "Name", "Description" and "Default".
    /// <see cref="ServiceProviderOfficeZoneGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4429""}]")]
    public class ServiceProviderOfficeZoneGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _officeZoneTable;

        [XmlElement(ElementName = "officeZoneTable", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:4429")]
        public BroadWorksConnector.Ocip.Models.C.OCITable OfficeZoneTable
        {
            get => _officeZoneTable;
            set
            {
                OfficeZoneTableSpecified = true;
                _officeZoneTable = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneTableSpecified { get; set; }

    }
}
