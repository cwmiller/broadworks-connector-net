using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest22.
    /// The response contains a table with columns: "Phone Number", "E164 Phone Number".
    /// 
    /// The "Phone Number" column contains Mobile Subscriber DNs not yet assigned to any user.
    /// The "E164 Phone Number" column contains Mobile Subscriber DNs not yet assigned to any user in E.164 format.
    /// <see cref="EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""9ae9f7d53e566e21347e23e20e2a2a39:238""}]")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _availableMobileSubscriberDirectoryNumberTable;

        [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumberTable", IsNullable = false, Namespace = "")]
        [Group(@"9ae9f7d53e566e21347e23e20e2a2a39:238")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvailableMobileSubscriberDirectoryNumberTable
        {
            get => _availableMobileSubscriberDirectoryNumberTable;
            set
            {
                AvailableMobileSubscriberDirectoryNumberTableSpecified = true;
                _availableMobileSubscriberDirectoryNumberTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvailableMobileSubscriberDirectoryNumberTableSpecified { get; set; }

    }
}
