using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNetworkClassOfServiceGetRequest17.
    /// The response contains the Network Class of Service information.
    /// 
    /// Replaced by: SystemNetworkClassOfServiceGetResponse19sp1 in AS data mode
    /// <see cref="SystemNetworkClassOfServiceGetRequest17"/>
    /// <see cref="SystemNetworkClassOfServiceGetResponse19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11515""}]")]
    public class SystemNetworkClassOfServiceGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = (value != null);
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile0;

        [XmlElement(ElementName = "communicationBarringProfile0", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile0
        {
            get => _communicationBarringProfile0;
            set
            {
                CommunicationBarringProfile0Specified = (value != null);
                _communicationBarringProfile0 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile0Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile1;

        [XmlElement(ElementName = "communicationBarringProfile1", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile1
        {
            get => _communicationBarringProfile1;
            set
            {
                CommunicationBarringProfile1Specified = (value != null);
                _communicationBarringProfile1 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile1Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile2;

        [XmlElement(ElementName = "communicationBarringProfile2", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile2
        {
            get => _communicationBarringProfile2;
            set
            {
                CommunicationBarringProfile2Specified = (value != null);
                _communicationBarringProfile2 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile2Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile3;

        [XmlElement(ElementName = "communicationBarringProfile3", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile3
        {
            get => _communicationBarringProfile3;
            set
            {
                CommunicationBarringProfile3Specified = (value != null);
                _communicationBarringProfile3 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile3Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile4;

        [XmlElement(ElementName = "communicationBarringProfile4", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile4
        {
            get => _communicationBarringProfile4;
            set
            {
                CommunicationBarringProfile4Specified = (value != null);
                _communicationBarringProfile4 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile4Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile5;

        [XmlElement(ElementName = "communicationBarringProfile5", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile5
        {
            get => _communicationBarringProfile5;
            set
            {
                CommunicationBarringProfile5Specified = (value != null);
                _communicationBarringProfile5 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile5Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile6;

        [XmlElement(ElementName = "communicationBarringProfile6", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile6
        {
            get => _communicationBarringProfile6;
            set
            {
                CommunicationBarringProfile6Specified = (value != null);
                _communicationBarringProfile6 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile6Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile7;

        [XmlElement(ElementName = "communicationBarringProfile7", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile7
        {
            get => _communicationBarringProfile7;
            set
            {
                CommunicationBarringProfile7Specified = (value != null);
                _communicationBarringProfile7 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile7Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile8;

        [XmlElement(ElementName = "communicationBarringProfile8", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile8
        {
            get => _communicationBarringProfile8;
            set
            {
                CommunicationBarringProfile8Specified = (value != null);
                _communicationBarringProfile8 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile8Specified { get; set; }

        protected BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile _communicationBarringProfile9;

        [XmlElement(ElementName = "communicationBarringProfile9", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        public BroadWorksConnector.Ocip.Models.NetworkClassOfServiceCommunicationBarringProfile CommunicationBarringProfile9
        {
            get => _communicationBarringProfile9;
            set
            {
                CommunicationBarringProfile9Specified = (value != null);
                _communicationBarringProfile9 = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringProfile9Specified { get; set; }

        protected string _networkTranslationIndex;

        [XmlElement(ElementName = "networkTranslationIndex", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:11515")]
        [MinLength(1)]
        [MaxLength(128)]
        public string NetworkTranslationIndex
        {
            get => _networkTranslationIndex;
            set
            {
                NetworkTranslationIndexSpecified = (value != null);
                _networkTranslationIndex = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkTranslationIndexSpecified { get; set; }

    }
}
