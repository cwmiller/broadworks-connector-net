using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupIMRNGetListRequest.
    /// <see cref="GroupIMRNGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5365""}]")]
    public class GroupIMRNGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _imrn = new List<string>();

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5365")]
        public List<string> Imrn
        {
            get => _imrn;
            set
            {
                ImrnSpecified = true;
                _imrn = value;
            }
        }

        [XmlIgnore]
        public bool ImrnSpecified { get; set; }

    }
}
