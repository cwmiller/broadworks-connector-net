using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupNetworkClassOfServiceGetAssignedListRequest.
    /// Contains a table of all Network Classes of Service assigned to
    /// the group. The column headings are: "Name", "Description" and "Default".
    /// <see cref="GroupNetworkClassOfServiceGetAssignedListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:6265""}]")]
    public class GroupNetworkClassOfServiceGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

        [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:6265")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable
        {
            get => _networkClassOfServiceTable;
            set
            {
                NetworkClassOfServiceTableSpecified = true;
                _networkClassOfServiceTable = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceTableSpecified { get; set; }

    }
}
