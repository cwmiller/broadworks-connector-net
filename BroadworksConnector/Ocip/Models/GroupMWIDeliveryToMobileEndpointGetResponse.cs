using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupMWIDeliveryToMobileEndpointGetRequest.
    /// 
    /// The templateActivationTable contains the list of templates defined for the group.
    /// The column headings are "Enable", "Language", "Type".
    /// <see cref="GroupMWIDeliveryToMobileEndpointGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1ea80c1e18c25d0eed23dbc7bd18f1dc:171""}]")]
    public class GroupMWIDeliveryToMobileEndpointGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:171")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UseSettingLevelSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _templateActivationTable;

        [XmlElement(ElementName = "templateActivationTable", IsNullable = false, Namespace = "")]
        [Group(@"1ea80c1e18c25d0eed23dbc7bd18f1dc:171")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TemplateActivationTable
        {
            get => _templateActivationTable;
            set
            {
                TemplateActivationTableSpecified = true;
                _templateActivationTable = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateActivationTableSpecified { get; set; }

    }
}
