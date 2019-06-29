using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetActivationListRequest.
    /// The response contains a table with columns: "Phone Numbers", and "Activated".  ".  Phone Numbers are only returned if assigned to a user.
    /// The "Phone Numbers" column contains either a single DN or a range of DNs.
    /// The "Activated" column indicates if the phone number(s) are activated or not.
    /// <see cref="GroupDnGetActivationListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:4155""}]")]
    public class GroupDnGetActivationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:4155")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable
        {
            get => _dnTable;
            set
            {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        protected bool DnTableSpecified { get; set; }

    }
}
