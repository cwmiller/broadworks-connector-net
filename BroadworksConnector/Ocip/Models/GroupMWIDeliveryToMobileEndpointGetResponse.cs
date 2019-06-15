using System;
using System.Xml.Serialization;
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
     
    public class GroupMWIDeliveryToMobileEndpointGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel UseSettingLevel {
            get => _useSettingLevel;
            set {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingLevelSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.C.OCITable _templateActivationTable;

        [XmlElement(ElementName = "templateActivationTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable TemplateActivationTable {
            get => _templateActivationTable;
            set {
                TemplateActivationTableSpecified = true;
                _templateActivationTable = value;
            }
        }

        [XmlIgnore]
        public bool TemplateActivationTableSpecified { get; set; }
        
    }
}
