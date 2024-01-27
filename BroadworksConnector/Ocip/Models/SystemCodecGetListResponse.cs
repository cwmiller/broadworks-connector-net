using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCodecGetListRequest.
    /// <see cref="SystemCodecGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5600""}]")]
    public class SystemCodecGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.Codec> _codec = new List<BroadWorksConnector.Ocip.Models.Codec>();

        [XmlElement(ElementName = "codec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:5600")]
        public List<BroadWorksConnector.Ocip.Models.Codec> Codec
        {
            get => _codec;
            set
            {
                CodecSpecified = true;
                _codec = value;
            }
        }

        [XmlIgnore]
        protected bool CodecSpecified { get; set; }

    }
}
