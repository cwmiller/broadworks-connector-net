using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemIntegratedIMPGetRequest25.
    /// The response contains the system Integrated IMP service attributes.
    /// 
    /// The following elements are only used in AS data mode:
    /// boshURL
    /// propagateImpErrorDetails
    /// <see cref="SystemIntegratedIMPGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""37cec25308bcc82fe5a80bf541c42c89:291""}]")]
    public class SystemIntegratedIMPGetResponse25 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _serviceDomain;

        [XmlElement(ElementName = "serviceDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"37cec25308bcc82fe5a80bf541c42c89:291")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ServiceDomain
        {
            get => _serviceDomain;
            set
            {
                ServiceDomainSpecified = true;
                _serviceDomain = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceDomainSpecified { get; set; }

        protected int _servicePort;

        [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"37cec25308bcc82fe5a80bf541c42c89:291")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int ServicePort
        {
            get => _servicePort;
            set
            {
                ServicePortSpecified = true;
                _servicePort = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePortSpecified { get; set; }

        protected bool _addServiceProviderInIMPUserId;

        [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false, Namespace = "")]
        [Group(@"37cec25308bcc82fe5a80bf541c42c89:291")]
        public bool AddServiceProviderInIMPUserId
        {
            get => _addServiceProviderInIMPUserId;
            set
            {
                AddServiceProviderInIMPUserIdSpecified = true;
                _addServiceProviderInIMPUserId = value;
            }
        }

        [XmlIgnore]
        protected bool AddServiceProviderInIMPUserIdSpecified { get; set; }

        protected string _boshURL;

        [XmlElement(ElementName = "boshURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"37cec25308bcc82fe5a80bf541c42c89:291")]
        [MinLength(1)]
        [MaxLength(256)]
        public string BoshURL
        {
            get => _boshURL;
            set
            {
                BoshURLSpecified = true;
                _boshURL = value;
            }
        }

        [XmlIgnore]
        protected bool BoshURLSpecified { get; set; }

        protected bool _allowImpPasswordRetrieval;

        [XmlElement(ElementName = "allowImpPasswordRetrieval", IsNullable = false, Namespace = "")]
        [Group(@"37cec25308bcc82fe5a80bf541c42c89:291")]
        public bool AllowImpPasswordRetrieval
        {
            get => _allowImpPasswordRetrieval;
            set
            {
                AllowImpPasswordRetrievalSpecified = true;
                _allowImpPasswordRetrieval = value;
            }
        }

        [XmlIgnore]
        protected bool AllowImpPasswordRetrievalSpecified { get; set; }

        protected bool _propagateImpErrorDetails;

        [XmlElement(ElementName = "propagateImpErrorDetails", IsNullable = false, Namespace = "")]
        [Group(@"37cec25308bcc82fe5a80bf541c42c89:291")]
        public bool PropagateImpErrorDetails
        {
            get => _propagateImpErrorDetails;
            set
            {
                PropagateImpErrorDetailsSpecified = true;
                _propagateImpErrorDetails = value;
            }
        }

        [XmlIgnore]
        protected bool PropagateImpErrorDetailsSpecified { get; set; }

    }
}
