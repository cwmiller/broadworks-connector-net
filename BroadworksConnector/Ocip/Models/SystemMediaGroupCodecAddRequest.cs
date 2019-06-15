using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a media to a media group.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemMediaGroupCodecAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
        private string _codecName;

        [XmlElement(ElementName = "codecName", IsNullable = false, Namespace = "")]
        public string CodecName {
            get => _codecName;
            set {
                CodecNameSpecified = true;
                _codecName = value;
            }
        }

        [XmlIgnore]
        public bool CodecNameSpecified { get; set; }
        
        private int _codecWeight;

        [XmlElement(ElementName = "codecWeight", IsNullable = false, Namespace = "")]
        public int CodecWeight {
            get => _codecWeight;
            set {
                CodecWeightSpecified = true;
                _codecWeight = value;
            }
        }

        [XmlIgnore]
        public bool CodecWeightSpecified { get; set; }
        
    }
}
