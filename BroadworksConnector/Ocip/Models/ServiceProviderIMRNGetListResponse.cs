using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderIMRNGetListRequest.
    /// <see cref="ServiceProviderIMRNGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:4780""}]")]
    public class ServiceProviderIMRNGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _imrn = new List<string>();

        [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:4780")]
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
        protected bool ImrnSpecified { get; set; }

    }
}
