using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjektCona1.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class data
    {

        private string languageField;

        private string creditField;

        private string credit_urlField;

        private string image_urlField;

        private string suggested_pickupField;

        private byte suggested_pickup_periodField;

        private string webcam_url_baseField;

        private string icon_url_baseField;

        private string icon_formatField;

        private string docs_urlField;

        private string disclaimer_urlField;

        private string copyright_urlField;

        private string privacy_policy_urlField;

        private string managing_editorField;

        private string web_masterField;

        private string generatorField;

        private object meteosi_urlField;

        private string two_day_history_urlField;

        private dataMetData[] metDataField;

        private string idField;

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public string credit_url
        {
            get
            {
                return this.credit_urlField;
            }
            set
            {
                this.credit_urlField = value;
            }
        }

        /// <remarks/>
        public string image_url
        {
            get
            {
                return this.image_urlField;
            }
            set
            {
                this.image_urlField = value;
            }
        }

        /// <remarks/>
        public string suggested_pickup
        {
            get
            {
                return this.suggested_pickupField;
            }
            set
            {
                this.suggested_pickupField = value;
            }
        }

        /// <remarks/>
        public byte suggested_pickup_period
        {
            get
            {
                return this.suggested_pickup_periodField;
            }
            set
            {
                this.suggested_pickup_periodField = value;
            }
        }

        /// <remarks/>
        public string webcam_url_base
        {
            get
            {
                return this.webcam_url_baseField;
            }
            set
            {
                this.webcam_url_baseField = value;
            }
        }

        /// <remarks/>
        public string icon_url_base
        {
            get
            {
                return this.icon_url_baseField;
            }
            set
            {
                this.icon_url_baseField = value;
            }
        }

        /// <remarks/>
        public string icon_format
        {
            get
            {
                return this.icon_formatField;
            }
            set
            {
                this.icon_formatField = value;
            }
        }

        /// <remarks/>
        public string docs_url
        {
            get
            {
                return this.docs_urlField;
            }
            set
            {
                this.docs_urlField = value;
            }
        }

        /// <remarks/>
        public string disclaimer_url
        {
            get
            {
                return this.disclaimer_urlField;
            }
            set
            {
                this.disclaimer_urlField = value;
            }
        }

        /// <remarks/>
        public string copyright_url
        {
            get
            {
                return this.copyright_urlField;
            }
            set
            {
                this.copyright_urlField = value;
            }
        }

        /// <remarks/>
        public string privacy_policy_url
        {
            get
            {
                return this.privacy_policy_urlField;
            }
            set
            {
                this.privacy_policy_urlField = value;
            }
        }

        /// <remarks/>
        public string managing_editor
        {
            get
            {
                return this.managing_editorField;
            }
            set
            {
                this.managing_editorField = value;
            }
        }

        /// <remarks/>
        public string web_master
        {
            get
            {
                return this.web_masterField;
            }
            set
            {
                this.web_masterField = value;
            }
        }

        /// <remarks/>
        public string generator
        {
            get
            {
                return this.generatorField;
            }
            set
            {
                this.generatorField = value;
            }
        }

        /// <remarks/>
        public object meteosi_url
        {
            get
            {
                return this.meteosi_urlField;
            }
            set
            {
                this.meteosi_urlField = value;
            }
        }

        /// <remarks/>
        public string two_day_history_url
        {
            get
            {
                return this.two_day_history_urlField;
            }
            set
            {
                this.two_day_history_urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metData")]
        public dataMetData[] metData
        {
            get
            {
                return this.metDataField;
            }
            set
            {
                this.metDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMetData
    {

        private string domain_titleField;

        private object domain_idField;

        private string domain_shortTitleField;

        private string domain_longTitleField;

        private string domain_meteosiIdField;

        private decimal domain_latField;

        private decimal domain_lonField;

        private decimal domain_altitudeField;

        private string dataSource_titleField;

        private string sunriseField;

        private string sunsetField;

        private string tsValid_issuedField;

        private string tsValid_issued_dayField;

        private string tsValid_issued_UTCField;

        private string tsValid_issued_RFC822Field;

        private string tsUpdatedField;

        private string tsUpdated_dayField;

        private string tsUpdated_UTCField;

        private string tsUpdated_RFC822Field;

        private string valid_dayField;

        private string validField;

        private string valid_UTCField;

        private string validStartField;

        private string validEndField;

        private string nn_var_descField;

        private string wwsyn_var_descField;

        private string nn_iconwwsyn_iconField;

        private string wwsyn_iconField;

        private string t_var_descField;

        private string t_var_unitField;

        private decimal tField;

        private byte t_stateField;

        private string td_var_descField;

        private string td_var_unitField;

        private decimal tdField;

        private byte td_stateField;

        private string tavg_var_descField;

        private string tavg_var_unitField;

        private decimal tavgField;

        private byte tavg_stateField;

        private string tx_var_descField;

        private string tx_var_unitField;

        private decimal txField;

        private byte tx_stateField;

        private string tn_var_descField;

        private string tn_var_unitField;

        private decimal tnField;

        private byte tn_stateField;

        private string rh_var_descField;

        private string rh_var_unitField;

        private byte rhField;

        private byte rh_stateField;

        private string rhavg_var_descField;

        private string rhavg_var_unitField;

        private byte rhavgField;

        private byte rhavg_stateField;

        private string dd_var_descField;

        private string dd_var_unitField;

        private ushort dd_valField;

        private string dd_shortTextField;

        private string dd_iconField;

        private byte dd_stateField;

        private string ddavg_var_descField;

        private string ddavg_var_unitField;

        private ushort ddavg_valField;

        private string ddavg_shortTextField;

        private string ddavg_longTextField;

        private string ddavg_iconField;

        private byte ddavg_stateField;

        private string ddmax_var_descField;

        private string ddmax_var_unitField;

        private ushort ddmax_valField;

        private string ddmax_shortTextField;

        private string ddmax_iconField;

        private byte ddmax_stateField;

        private string ff_var_descField;

        private string ff_var_unitField;

        private decimal ff_valField;

        private byte ff_val_kmhField;

        private byte ff_stateField;

        private string ffavg_var_descField;

        private string ffavg_var_unitField;

        private decimal ffavg_valField;

        private byte ffavg_val_kmhField;

        private byte ffavg_stateField;

        private string ffmax_var_descField;

        private string ffmax_var_unitField;

        private decimal ffmax_valField;

        private byte ffmax_val_kmhField;

        private byte ffmax_stateField;

        private string msl_var_descField;

        private string msl_var_unitField;

        private object mslField;

        private object msl_stateField;

        private string mslavg_var_descField;

        private string mslavg_var_unitField;

        private object mslavgField;

        private object mslavg_stateField;

        private string p_var_descField;

        private string p_var_unitField;

        private object pField;

        private object p_stateField;

        private string pavg_var_descField;

        private string pavg_var_unitField;

        private object pavgField;

        private object pavg_stateField;

        private string rr_var_descField;

        private string rr_var_unitField;

        private decimal rr_valField;

        private byte rr_stateField;

        private string snow_var_descField;

        private string snow_var_unitField;

        private object snowField;

        private object snow_stateField;

        private string tp_12h_acc_var_descField;

        private string tp_12h_acc_var_unitField;

        private decimal tp_12h_accField;

        private byte tp_12h_acc_stateField;

        private string tp_24h_acc_var_descField;

        private string tp_24h_acc_var_unitField;

        private string tp_24h_accField;

        private string tp_24h_acc_stateField;

        private string tw_var_descField;

        private string tw_var_unitField;

        private object twField;

        private object tw_stateField;

        private string gSunRad_var_descField;

        private string gSunRad_var_unitField;

        private object gSunRadField;

        private object gSunRad_stateField;

        private string gSunRadavg_var_descField;

        private string gSunRadavg_var_unitField;

        private object gSunRadavgField;

        private object gSunRadavg_stateField;

        private string diffSunRad_var_descField;

        private string diffSunRad_var_unitField;

        private object diffSunRadField;

        private object diffSunRad_stateField;

        private string diffSunRadavg_var_descField;

        private string diffSunRadavg_var_unitField;

        private object diffSunRadavgField;

        private object diffSunRadavg_stateField;

        private string vis_descField;

        private object vis_valField;

        private string vis_unitField;

        private string t_5_cm_var_descField;

        private string t_5_cm_var_unitField;

        private object t_5_cmField;

        private object t_5_cm_stateField;

        private string tavg_5_cm_var_descField;

        private string tavg_5_cm_var_unitField;

        private object tavg_5_cmField;

        private object tavg_5_cm_stateField;

        private string tg_5_cm_var_descField;

        private string tg_5_cm_var_unitField;

        private object tg_5_cmField;

        private object tg_5_cm_stateField;

        private string tgavg_5_cm_var_descField;

        private string tgavg_5_cm_var_unitField;

        private object tgavg_5_cmField;

        private object tgavg_5_cm_stateField;

        private string tg_10_cm_var_descField;

        private string tg_10_cm_var_unitField;

        private object tg_10_cmField;

        private object tg_10_cm_stateField;

        private string tgavg_10_cm_var_descField;

        private string tgavg_10_cm_var_unitField;

        private object tgavg_10_cmField;

        private object tgavg_10_cm_stateField;

        private string tg_20_cm_var_descField;

        private string tg_20_cm_var_unitField;

        private object tg_20_cmField;

        private object tg_20_cm_stateField;

        private string tgavg_20_cm_var_descField;

        private string tgavg_20_cm_var_unitField;

        private object tgavg_20_cmField;

        private object tgavg_20_cm_stateField;

        private string tg_30_cm_var_descField;

        private string tg_30_cm_var_unitField;

        private object tg_30_cmField;

        private object tg_30_cm_stateField;

        private string tgavg_30_cm_var_descField;

        private string tgavg_30_cm_var_unitField;

        private object tgavg_30_cmField;

        private object tgavg_30_cm_stateField;

        private string tg_50_cm_var_descField;

        private string tg_50_cm_var_unitField;

        private object tg_50_cmField;

        private object tg_50_cm_stateField;

        private string tgavg_50_cm_var_descField;

        private string tgavg_50_cm_var_unitField;

        private object tgavg_50_cmField;

        private object tgavg_50_cm_stateField;

        private string hhs_var_descField;

        private string hhs_var_unitField;

        private string ns_var_descField;

        private string ns_var_unitField;

        private object hhs1_valField;

        private object hhs1_stateField;

        private object ns1_valField;

        private object ns1_stateField;

        private object hhs2_valField;

        private object hhs2_stateField;

        private object ns2_valField;

        private object ns2_stateField;

        private object hhs3_valField;

        private object hhs3_stateField;

        private object ns3_valField;

        private object ns3_stateField;

        private object hhs4_valField;

        private object hhs4_stateField;

        private object ns4_valField;

        private object ns4_stateField;

        private decimal rrHhField;

        /// <remarks/>
        public string domain_title
        {
            get
            {
                return this.domain_titleField;
            }
            set
            {
                this.domain_titleField = value;
            }
        }

        /// <remarks/>
        public object domain_id
        {
            get
            {
                return this.domain_idField;
            }
            set
            {
                this.domain_idField = value;
            }
        }

        /// <remarks/>
        public string domain_shortTitle
        {
            get
            {
                return this.domain_shortTitleField;
            }
            set
            {
                this.domain_shortTitleField = value;
            }
        }

        /// <remarks/>
        public string domain_longTitle
        {
            get
            {
                return this.domain_longTitleField;
            }
            set
            {
                this.domain_longTitleField = value;
            }
        }

        /// <remarks/>
        public string domain_meteosiId
        {
            get
            {
                return this.domain_meteosiIdField;
            }
            set
            {
                this.domain_meteosiIdField = value;
            }
        }

        /// <remarks/>
        public decimal domain_lat
        {
            get
            {
                return this.domain_latField;
            }
            set
            {
                this.domain_latField = value;
            }
        }

        /// <remarks/>
        public decimal domain_lon
        {
            get
            {
                return this.domain_lonField;
            }
            set
            {
                this.domain_lonField = value;
            }
        }

        /// <remarks/>
        public decimal domain_altitude
        {
            get
            {
                return this.domain_altitudeField;
            }
            set
            {
                this.domain_altitudeField = value;
            }
        }

        /// <remarks/>
        public string dataSource_title
        {
            get
            {
                return this.dataSource_titleField;
            }
            set
            {
                this.dataSource_titleField = value;
            }
        }

        /// <remarks/>
        public string sunrise
        {
            get
            {
                return this.sunriseField;
            }
            set
            {
                this.sunriseField = value;
            }
        }

        /// <remarks/>
        public string sunset
        {
            get
            {
                return this.sunsetField;
            }
            set
            {
                this.sunsetField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued
        {
            get
            {
                return this.tsValid_issuedField;
            }
            set
            {
                this.tsValid_issuedField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued_day
        {
            get
            {
                return this.tsValid_issued_dayField;
            }
            set
            {
                this.tsValid_issued_dayField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued_UTC
        {
            get
            {
                return this.tsValid_issued_UTCField;
            }
            set
            {
                this.tsValid_issued_UTCField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued_RFC822
        {
            get
            {
                return this.tsValid_issued_RFC822Field;
            }
            set
            {
                this.tsValid_issued_RFC822Field = value;
            }
        }

        /// <remarks/>
        public string tsUpdated
        {
            get
            {
                return this.tsUpdatedField;
            }
            set
            {
                this.tsUpdatedField = value;
            }
        }

        /// <remarks/>
        public string tsUpdated_day
        {
            get
            {
                return this.tsUpdated_dayField;
            }
            set
            {
                this.tsUpdated_dayField = value;
            }
        }

        /// <remarks/>
        public string tsUpdated_UTC
        {
            get
            {
                return this.tsUpdated_UTCField;
            }
            set
            {
                this.tsUpdated_UTCField = value;
            }
        }

        /// <remarks/>
        public string tsUpdated_RFC822
        {
            get
            {
                return this.tsUpdated_RFC822Field;
            }
            set
            {
                this.tsUpdated_RFC822Field = value;
            }
        }

        /// <remarks/>
        public string valid_day
        {
            get
            {
                return this.valid_dayField;
            }
            set
            {
                this.valid_dayField = value;
            }
        }

        /// <remarks/>
        public string valid
        {
            get
            {
                return this.validField;
            }
            set
            {
                this.validField = value;
            }
        }

        /// <remarks/>
        public string valid_UTC
        {
            get
            {
                return this.valid_UTCField;
            }
            set
            {
                this.valid_UTCField = value;
            }
        }

        /// <remarks/>
        public string validStart
        {
            get
            {
                return this.validStartField;
            }
            set
            {
                this.validStartField = value;
            }
        }

        /// <remarks/>
        public string validEnd
        {
            get
            {
                return this.validEndField;
            }
            set
            {
                this.validEndField = value;
            }
        }

        /// <remarks/>
        public string nn_var_desc
        {
            get
            {
                return this.nn_var_descField;
            }
            set
            {
                this.nn_var_descField = value;
            }
        }

        /// <remarks/>
        public string wwsyn_var_desc
        {
            get
            {
                return this.wwsyn_var_descField;
            }
            set
            {
                this.wwsyn_var_descField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nn_icon-wwsyn_icon")]
        public string nn_iconwwsyn_icon
        {
            get
            {
                return this.nn_iconwwsyn_iconField;
            }
            set
            {
                this.nn_iconwwsyn_iconField = value;
            }
        }

        /// <remarks/>
        public string wwsyn_icon
        {
            get
            {
                return this.wwsyn_iconField;
            }
            set
            {
                this.wwsyn_iconField = value;
            }
        }

        /// <remarks/>
        public string t_var_desc
        {
            get
            {
                return this.t_var_descField;
            }
            set
            {
                this.t_var_descField = value;
            }
        }

        /// <remarks/>
        public string t_var_unit
        {
            get
            {
                return this.t_var_unitField;
            }
            set
            {
                this.t_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal t
        {
            get
            {
                return this.tField;
            }
            set
            {
                this.tField = value;
            }
        }

        /// <remarks/>
        public byte t_state
        {
            get
            {
                return this.t_stateField;
            }
            set
            {
                this.t_stateField = value;
            }
        }

        /// <remarks/>
        public string td_var_desc
        {
            get
            {
                return this.td_var_descField;
            }
            set
            {
                this.td_var_descField = value;
            }
        }

        /// <remarks/>
        public string td_var_unit
        {
            get
            {
                return this.td_var_unitField;
            }
            set
            {
                this.td_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal td
        {
            get
            {
                return this.tdField;
            }
            set
            {
                this.tdField = value;
            }
        }

        /// <remarks/>
        public byte td_state
        {
            get
            {
                return this.td_stateField;
            }
            set
            {
                this.td_stateField = value;
            }
        }

        /// <remarks/>
        public string tavg_var_desc
        {
            get
            {
                return this.tavg_var_descField;
            }
            set
            {
                this.tavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string tavg_var_unit
        {
            get
            {
                return this.tavg_var_unitField;
            }
            set
            {
                this.tavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal tavg
        {
            get
            {
                return this.tavgField;
            }
            set
            {
                this.tavgField = value;
            }
        }

        /// <remarks/>
        public byte tavg_state
        {
            get
            {
                return this.tavg_stateField;
            }
            set
            {
                this.tavg_stateField = value;
            }
        }

        /// <remarks/>
        public string tx_var_desc
        {
            get
            {
                return this.tx_var_descField;
            }
            set
            {
                this.tx_var_descField = value;
            }
        }

        /// <remarks/>
        public string tx_var_unit
        {
            get
            {
                return this.tx_var_unitField;
            }
            set
            {
                this.tx_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal tx
        {
            get
            {
                return this.txField;
            }
            set
            {
                this.txField = value;
            }
        }

        /// <remarks/>
        public byte tx_state
        {
            get
            {
                return this.tx_stateField;
            }
            set
            {
                this.tx_stateField = value;
            }
        }

        /// <remarks/>
        public string tn_var_desc
        {
            get
            {
                return this.tn_var_descField;
            }
            set
            {
                this.tn_var_descField = value;
            }
        }

        /// <remarks/>
        public string tn_var_unit
        {
            get
            {
                return this.tn_var_unitField;
            }
            set
            {
                this.tn_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal tn
        {
            get
            {
                return this.tnField;
            }
            set
            {
                this.tnField = value;
            }
        }

        /// <remarks/>
        public byte tn_state
        {
            get
            {
                return this.tn_stateField;
            }
            set
            {
                this.tn_stateField = value;
            }
        }

        /// <remarks/>
        public string rh_var_desc
        {
            get
            {
                return this.rh_var_descField;
            }
            set
            {
                this.rh_var_descField = value;
            }
        }

        /// <remarks/>
        public string rh_var_unit
        {
            get
            {
                return this.rh_var_unitField;
            }
            set
            {
                this.rh_var_unitField = value;
            }
        }

        /// <remarks/>
        public byte rh
        {
            get
            {
                return this.rhField;
            }
            set
            {
                this.rhField = value;
            }
        }

        /// <remarks/>
        public byte rh_state
        {
            get
            {
                return this.rh_stateField;
            }
            set
            {
                this.rh_stateField = value;
            }
        }

        /// <remarks/>
        public string rhavg_var_desc
        {
            get
            {
                return this.rhavg_var_descField;
            }
            set
            {
                this.rhavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string rhavg_var_unit
        {
            get
            {
                return this.rhavg_var_unitField;
            }
            set
            {
                this.rhavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public byte rhavg
        {
            get
            {
                return this.rhavgField;
            }
            set
            {
                this.rhavgField = value;
            }
        }

        /// <remarks/>
        public byte rhavg_state
        {
            get
            {
                return this.rhavg_stateField;
            }
            set
            {
                this.rhavg_stateField = value;
            }
        }

        /// <remarks/>
        public string dd_var_desc
        {
            get
            {
                return this.dd_var_descField;
            }
            set
            {
                this.dd_var_descField = value;
            }
        }

        /// <remarks/>
        public string dd_var_unit
        {
            get
            {
                return this.dd_var_unitField;
            }
            set
            {
                this.dd_var_unitField = value;
            }
        }

        /// <remarks/>
        public ushort dd_val
        {
            get
            {
                return this.dd_valField;
            }
            set
            {
                this.dd_valField = value;
            }
        }

        /// <remarks/>
        public string dd_shortText
        {
            get
            {
                return this.dd_shortTextField;
            }
            set
            {
                this.dd_shortTextField = value;
            }
        }

        /// <remarks/>
        public string dd_icon
        {
            get
            {
                return this.dd_iconField;
            }
            set
            {
                this.dd_iconField = value;
            }
        }

        /// <remarks/>
        public byte dd_state
        {
            get
            {
                return this.dd_stateField;
            }
            set
            {
                this.dd_stateField = value;
            }
        }

        /// <remarks/>
        public string ddavg_var_desc
        {
            get
            {
                return this.ddavg_var_descField;
            }
            set
            {
                this.ddavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string ddavg_var_unit
        {
            get
            {
                return this.ddavg_var_unitField;
            }
            set
            {
                this.ddavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public ushort ddavg_val
        {
            get
            {
                return this.ddavg_valField;
            }
            set
            {
                this.ddavg_valField = value;
            }
        }

        /// <remarks/>
        public string ddavg_shortText
        {
            get
            {
                return this.ddavg_shortTextField;
            }
            set
            {
                this.ddavg_shortTextField = value;
            }
        }

        /// <remarks/>
        public string ddavg_longText
        {
            get
            {
                return this.ddavg_longTextField;
            }
            set
            {
                this.ddavg_longTextField = value;
            }
        }

        /// <remarks/>
        public string ddavg_icon
        {
            get
            {
                return this.ddavg_iconField;
            }
            set
            {
                this.ddavg_iconField = value;
            }
        }

        /// <remarks/>
        public byte ddavg_state
        {
            get
            {
                return this.ddavg_stateField;
            }
            set
            {
                this.ddavg_stateField = value;
            }
        }

        /// <remarks/>
        public string ddmax_var_desc
        {
            get
            {
                return this.ddmax_var_descField;
            }
            set
            {
                this.ddmax_var_descField = value;
            }
        }

        /// <remarks/>
        public string ddmax_var_unit
        {
            get
            {
                return this.ddmax_var_unitField;
            }
            set
            {
                this.ddmax_var_unitField = value;
            }
        }

        /// <remarks/>
        public ushort ddmax_val
        {
            get
            {
                return this.ddmax_valField;
            }
            set
            {
                this.ddmax_valField = value;
            }
        }

        /// <remarks/>
        public string ddmax_shortText
        {
            get
            {
                return this.ddmax_shortTextField;
            }
            set
            {
                this.ddmax_shortTextField = value;
            }
        }

        /// <remarks/>
        public string ddmax_icon
        {
            get
            {
                return this.ddmax_iconField;
            }
            set
            {
                this.ddmax_iconField = value;
            }
        }

        /// <remarks/>
        public byte ddmax_state
        {
            get
            {
                return this.ddmax_stateField;
            }
            set
            {
                this.ddmax_stateField = value;
            }
        }

        /// <remarks/>
        public string ff_var_desc
        {
            get
            {
                return this.ff_var_descField;
            }
            set
            {
                this.ff_var_descField = value;
            }
        }

        /// <remarks/>
        public string ff_var_unit
        {
            get
            {
                return this.ff_var_unitField;
            }
            set
            {
                this.ff_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal ff_val
        {
            get
            {
                return this.ff_valField;
            }
            set
            {
                this.ff_valField = value;
            }
        }

        /// <remarks/>
        public byte ff_val_kmh
        {
            get
            {
                return this.ff_val_kmhField;
            }
            set
            {
                this.ff_val_kmhField = value;
            }
        }

        /// <remarks/>
        public byte ff_state
        {
            get
            {
                return this.ff_stateField;
            }
            set
            {
                this.ff_stateField = value;
            }
        }

        /// <remarks/>
        public string ffavg_var_desc
        {
            get
            {
                return this.ffavg_var_descField;
            }
            set
            {
                this.ffavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string ffavg_var_unit
        {
            get
            {
                return this.ffavg_var_unitField;
            }
            set
            {
                this.ffavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal ffavg_val
        {
            get
            {
                return this.ffavg_valField;
            }
            set
            {
                this.ffavg_valField = value;
            }
        }

        /// <remarks/>
        public byte ffavg_val_kmh
        {
            get
            {
                return this.ffavg_val_kmhField;
            }
            set
            {
                this.ffavg_val_kmhField = value;
            }
        }

        /// <remarks/>
        public byte ffavg_state
        {
            get
            {
                return this.ffavg_stateField;
            }
            set
            {
                this.ffavg_stateField = value;
            }
        }

        /// <remarks/>
        public string ffmax_var_desc
        {
            get
            {
                return this.ffmax_var_descField;
            }
            set
            {
                this.ffmax_var_descField = value;
            }
        }

        /// <remarks/>
        public string ffmax_var_unit
        {
            get
            {
                return this.ffmax_var_unitField;
            }
            set
            {
                this.ffmax_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal ffmax_val
        {
            get
            {
                return this.ffmax_valField;
            }
            set
            {
                this.ffmax_valField = value;
            }
        }

        /// <remarks/>
        public byte ffmax_val_kmh
        {
            get
            {
                return this.ffmax_val_kmhField;
            }
            set
            {
                this.ffmax_val_kmhField = value;
            }
        }

        /// <remarks/>
        public byte ffmax_state
        {
            get
            {
                return this.ffmax_stateField;
            }
            set
            {
                this.ffmax_stateField = value;
            }
        }

        /// <remarks/>
        public string msl_var_desc
        {
            get
            {
                return this.msl_var_descField;
            }
            set
            {
                this.msl_var_descField = value;
            }
        }

        /// <remarks/>
        public string msl_var_unit
        {
            get
            {
                return this.msl_var_unitField;
            }
            set
            {
                this.msl_var_unitField = value;
            }
        }

        /// <remarks/>
        public object msl
        {
            get
            {
                return this.mslField;
            }
            set
            {
                this.mslField = value;
            }
        }

        /// <remarks/>
        public object msl_state
        {
            get
            {
                return this.msl_stateField;
            }
            set
            {
                this.msl_stateField = value;
            }
        }

        /// <remarks/>
        public string mslavg_var_desc
        {
            get
            {
                return this.mslavg_var_descField;
            }
            set
            {
                this.mslavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string mslavg_var_unit
        {
            get
            {
                return this.mslavg_var_unitField;
            }
            set
            {
                this.mslavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public object mslavg
        {
            get
            {
                return this.mslavgField;
            }
            set
            {
                this.mslavgField = value;
            }
        }

        /// <remarks/>
        public object mslavg_state
        {
            get
            {
                return this.mslavg_stateField;
            }
            set
            {
                this.mslavg_stateField = value;
            }
        }

        /// <remarks/>
        public string p_var_desc
        {
            get
            {
                return this.p_var_descField;
            }
            set
            {
                this.p_var_descField = value;
            }
        }

        /// <remarks/>
        public string p_var_unit
        {
            get
            {
                return this.p_var_unitField;
            }
            set
            {
                this.p_var_unitField = value;
            }
        }

        /// <remarks/>
        public object p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        public object p_state
        {
            get
            {
                return this.p_stateField;
            }
            set
            {
                this.p_stateField = value;
            }
        }

        /// <remarks/>
        public string pavg_var_desc
        {
            get
            {
                return this.pavg_var_descField;
            }
            set
            {
                this.pavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string pavg_var_unit
        {
            get
            {
                return this.pavg_var_unitField;
            }
            set
            {
                this.pavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public object pavg
        {
            get
            {
                return this.pavgField;
            }
            set
            {
                this.pavgField = value;
            }
        }

        /// <remarks/>
        public object pavg_state
        {
            get
            {
                return this.pavg_stateField;
            }
            set
            {
                this.pavg_stateField = value;
            }
        }

        /// <remarks/>
        public string rr_var_desc
        {
            get
            {
                return this.rr_var_descField;
            }
            set
            {
                this.rr_var_descField = value;
            }
        }

        /// <remarks/>
        public string rr_var_unit
        {
            get
            {
                return this.rr_var_unitField;
            }
            set
            {
                this.rr_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal rr_val
        {
            get
            {
                return this.rr_valField;
            }
            set
            {
                this.rr_valField = value;
            }
        }

        /// <remarks/>
        public byte rr_state
        {
            get
            {
                return this.rr_stateField;
            }
            set
            {
                this.rr_stateField = value;
            }
        }

        /// <remarks/>
        public string snow_var_desc
        {
            get
            {
                return this.snow_var_descField;
            }
            set
            {
                this.snow_var_descField = value;
            }
        }

        /// <remarks/>
        public string snow_var_unit
        {
            get
            {
                return this.snow_var_unitField;
            }
            set
            {
                this.snow_var_unitField = value;
            }
        }

        /// <remarks/>
        public object snow
        {
            get
            {
                return this.snowField;
            }
            set
            {
                this.snowField = value;
            }
        }

        /// <remarks/>
        public object snow_state
        {
            get
            {
                return this.snow_stateField;
            }
            set
            {
                this.snow_stateField = value;
            }
        }

        /// <remarks/>
        public string tp_12h_acc_var_desc
        {
            get
            {
                return this.tp_12h_acc_var_descField;
            }
            set
            {
                this.tp_12h_acc_var_descField = value;
            }
        }

        /// <remarks/>
        public string tp_12h_acc_var_unit
        {
            get
            {
                return this.tp_12h_acc_var_unitField;
            }
            set
            {
                this.tp_12h_acc_var_unitField = value;
            }
        }

        /// <remarks/>
        public decimal tp_12h_acc
        {
            get
            {
                return this.tp_12h_accField;
            }
            set
            {
                this.tp_12h_accField = value;
            }
        }

        /// <remarks/>
        public byte tp_12h_acc_state
        {
            get
            {
                return this.tp_12h_acc_stateField;
            }
            set
            {
                this.tp_12h_acc_stateField = value;
            }
        }

        /// <remarks/>
        public string tp_24h_acc_var_desc
        {
            get
            {
                return this.tp_24h_acc_var_descField;
            }
            set
            {
                this.tp_24h_acc_var_descField = value;
            }
        }

        /// <remarks/>
        public string tp_24h_acc_var_unit
        {
            get
            {
                return this.tp_24h_acc_var_unitField;
            }
            set
            {
                this.tp_24h_acc_var_unitField = value;
            }
        }

        /// <remarks/>
        public string tp_24h_acc
        {
            get
            {
                return this.tp_24h_accField;
            }
            set
            {
                this.tp_24h_accField = value;
            }
        }

        /// <remarks/>
        public string tp_24h_acc_state
        {
            get
            {
                return this.tp_24h_acc_stateField;
            }
            set
            {
                this.tp_24h_acc_stateField = value;
            }
        }

        /// <remarks/>
        public string tw_var_desc
        {
            get
            {
                return this.tw_var_descField;
            }
            set
            {
                this.tw_var_descField = value;
            }
        }

        /// <remarks/>
        public string tw_var_unit
        {
            get
            {
                return this.tw_var_unitField;
            }
            set
            {
                this.tw_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tw
        {
            get
            {
                return this.twField;
            }
            set
            {
                this.twField = value;
            }
        }

        /// <remarks/>
        public object tw_state
        {
            get
            {
                return this.tw_stateField;
            }
            set
            {
                this.tw_stateField = value;
            }
        }

        /// <remarks/>
        public string gSunRad_var_desc
        {
            get
            {
                return this.gSunRad_var_descField;
            }
            set
            {
                this.gSunRad_var_descField = value;
            }
        }

        /// <remarks/>
        public string gSunRad_var_unit
        {
            get
            {
                return this.gSunRad_var_unitField;
            }
            set
            {
                this.gSunRad_var_unitField = value;
            }
        }

        /// <remarks/>
        public object gSunRad
        {
            get
            {
                return this.gSunRadField;
            }
            set
            {
                this.gSunRadField = value;
            }
        }

        /// <remarks/>
        public object gSunRad_state
        {
            get
            {
                return this.gSunRad_stateField;
            }
            set
            {
                this.gSunRad_stateField = value;
            }
        }

        /// <remarks/>
        public string gSunRadavg_var_desc
        {
            get
            {
                return this.gSunRadavg_var_descField;
            }
            set
            {
                this.gSunRadavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string gSunRadavg_var_unit
        {
            get
            {
                return this.gSunRadavg_var_unitField;
            }
            set
            {
                this.gSunRadavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public object gSunRadavg
        {
            get
            {
                return this.gSunRadavgField;
            }
            set
            {
                this.gSunRadavgField = value;
            }
        }

        /// <remarks/>
        public object gSunRadavg_state
        {
            get
            {
                return this.gSunRadavg_stateField;
            }
            set
            {
                this.gSunRadavg_stateField = value;
            }
        }

        /// <remarks/>
        public string diffSunRad_var_desc
        {
            get
            {
                return this.diffSunRad_var_descField;
            }
            set
            {
                this.diffSunRad_var_descField = value;
            }
        }

        /// <remarks/>
        public string diffSunRad_var_unit
        {
            get
            {
                return this.diffSunRad_var_unitField;
            }
            set
            {
                this.diffSunRad_var_unitField = value;
            }
        }

        /// <remarks/>
        public object diffSunRad
        {
            get
            {
                return this.diffSunRadField;
            }
            set
            {
                this.diffSunRadField = value;
            }
        }

        /// <remarks/>
        public object diffSunRad_state
        {
            get
            {
                return this.diffSunRad_stateField;
            }
            set
            {
                this.diffSunRad_stateField = value;
            }
        }

        /// <remarks/>
        public string diffSunRadavg_var_desc
        {
            get
            {
                return this.diffSunRadavg_var_descField;
            }
            set
            {
                this.diffSunRadavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string diffSunRadavg_var_unit
        {
            get
            {
                return this.diffSunRadavg_var_unitField;
            }
            set
            {
                this.diffSunRadavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public object diffSunRadavg
        {
            get
            {
                return this.diffSunRadavgField;
            }
            set
            {
                this.diffSunRadavgField = value;
            }
        }

        /// <remarks/>
        public object diffSunRadavg_state
        {
            get
            {
                return this.diffSunRadavg_stateField;
            }
            set
            {
                this.diffSunRadavg_stateField = value;
            }
        }

        /// <remarks/>
        public string vis_desc
        {
            get
            {
                return this.vis_descField;
            }
            set
            {
                this.vis_descField = value;
            }
        }

        /// <remarks/>
        public object vis_val
        {
            get
            {
                return this.vis_valField;
            }
            set
            {
                this.vis_valField = value;
            }
        }

        /// <remarks/>
        public string vis_unit
        {
            get
            {
                return this.vis_unitField;
            }
            set
            {
                this.vis_unitField = value;
            }
        }

        /// <remarks/>
        public string t_5_cm_var_desc
        {
            get
            {
                return this.t_5_cm_var_descField;
            }
            set
            {
                this.t_5_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string t_5_cm_var_unit
        {
            get
            {
                return this.t_5_cm_var_unitField;
            }
            set
            {
                this.t_5_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object t_5_cm
        {
            get
            {
                return this.t_5_cmField;
            }
            set
            {
                this.t_5_cmField = value;
            }
        }

        /// <remarks/>
        public object t_5_cm_state
        {
            get
            {
                return this.t_5_cm_stateField;
            }
            set
            {
                this.t_5_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tavg_5_cm_var_desc
        {
            get
            {
                return this.tavg_5_cm_var_descField;
            }
            set
            {
                this.tavg_5_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tavg_5_cm_var_unit
        {
            get
            {
                return this.tavg_5_cm_var_unitField;
            }
            set
            {
                this.tavg_5_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tavg_5_cm
        {
            get
            {
                return this.tavg_5_cmField;
            }
            set
            {
                this.tavg_5_cmField = value;
            }
        }

        /// <remarks/>
        public object tavg_5_cm_state
        {
            get
            {
                return this.tavg_5_cm_stateField;
            }
            set
            {
                this.tavg_5_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tg_5_cm_var_desc
        {
            get
            {
                return this.tg_5_cm_var_descField;
            }
            set
            {
                this.tg_5_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tg_5_cm_var_unit
        {
            get
            {
                return this.tg_5_cm_var_unitField;
            }
            set
            {
                this.tg_5_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tg_5_cm
        {
            get
            {
                return this.tg_5_cmField;
            }
            set
            {
                this.tg_5_cmField = value;
            }
        }

        /// <remarks/>
        public object tg_5_cm_state
        {
            get
            {
                return this.tg_5_cm_stateField;
            }
            set
            {
                this.tg_5_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tgavg_5_cm_var_desc
        {
            get
            {
                return this.tgavg_5_cm_var_descField;
            }
            set
            {
                this.tgavg_5_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tgavg_5_cm_var_unit
        {
            get
            {
                return this.tgavg_5_cm_var_unitField;
            }
            set
            {
                this.tgavg_5_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tgavg_5_cm
        {
            get
            {
                return this.tgavg_5_cmField;
            }
            set
            {
                this.tgavg_5_cmField = value;
            }
        }

        /// <remarks/>
        public object tgavg_5_cm_state
        {
            get
            {
                return this.tgavg_5_cm_stateField;
            }
            set
            {
                this.tgavg_5_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tg_10_cm_var_desc
        {
            get
            {
                return this.tg_10_cm_var_descField;
            }
            set
            {
                this.tg_10_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tg_10_cm_var_unit
        {
            get
            {
                return this.tg_10_cm_var_unitField;
            }
            set
            {
                this.tg_10_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tg_10_cm
        {
            get
            {
                return this.tg_10_cmField;
            }
            set
            {
                this.tg_10_cmField = value;
            }
        }

        /// <remarks/>
        public object tg_10_cm_state
        {
            get
            {
                return this.tg_10_cm_stateField;
            }
            set
            {
                this.tg_10_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tgavg_10_cm_var_desc
        {
            get
            {
                return this.tgavg_10_cm_var_descField;
            }
            set
            {
                this.tgavg_10_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tgavg_10_cm_var_unit
        {
            get
            {
                return this.tgavg_10_cm_var_unitField;
            }
            set
            {
                this.tgavg_10_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tgavg_10_cm
        {
            get
            {
                return this.tgavg_10_cmField;
            }
            set
            {
                this.tgavg_10_cmField = value;
            }
        }

        /// <remarks/>
        public object tgavg_10_cm_state
        {
            get
            {
                return this.tgavg_10_cm_stateField;
            }
            set
            {
                this.tgavg_10_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tg_20_cm_var_desc
        {
            get
            {
                return this.tg_20_cm_var_descField;
            }
            set
            {
                this.tg_20_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tg_20_cm_var_unit
        {
            get
            {
                return this.tg_20_cm_var_unitField;
            }
            set
            {
                this.tg_20_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tg_20_cm
        {
            get
            {
                return this.tg_20_cmField;
            }
            set
            {
                this.tg_20_cmField = value;
            }
        }

        /// <remarks/>
        public object tg_20_cm_state
        {
            get
            {
                return this.tg_20_cm_stateField;
            }
            set
            {
                this.tg_20_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tgavg_20_cm_var_desc
        {
            get
            {
                return this.tgavg_20_cm_var_descField;
            }
            set
            {
                this.tgavg_20_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tgavg_20_cm_var_unit
        {
            get
            {
                return this.tgavg_20_cm_var_unitField;
            }
            set
            {
                this.tgavg_20_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tgavg_20_cm
        {
            get
            {
                return this.tgavg_20_cmField;
            }
            set
            {
                this.tgavg_20_cmField = value;
            }
        }

        /// <remarks/>
        public object tgavg_20_cm_state
        {
            get
            {
                return this.tgavg_20_cm_stateField;
            }
            set
            {
                this.tgavg_20_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tg_30_cm_var_desc
        {
            get
            {
                return this.tg_30_cm_var_descField;
            }
            set
            {
                this.tg_30_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tg_30_cm_var_unit
        {
            get
            {
                return this.tg_30_cm_var_unitField;
            }
            set
            {
                this.tg_30_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tg_30_cm
        {
            get
            {
                return this.tg_30_cmField;
            }
            set
            {
                this.tg_30_cmField = value;
            }
        }

        /// <remarks/>
        public object tg_30_cm_state
        {
            get
            {
                return this.tg_30_cm_stateField;
            }
            set
            {
                this.tg_30_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tgavg_30_cm_var_desc
        {
            get
            {
                return this.tgavg_30_cm_var_descField;
            }
            set
            {
                this.tgavg_30_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tgavg_30_cm_var_unit
        {
            get
            {
                return this.tgavg_30_cm_var_unitField;
            }
            set
            {
                this.tgavg_30_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tgavg_30_cm
        {
            get
            {
                return this.tgavg_30_cmField;
            }
            set
            {
                this.tgavg_30_cmField = value;
            }
        }

        /// <remarks/>
        public object tgavg_30_cm_state
        {
            get
            {
                return this.tgavg_30_cm_stateField;
            }
            set
            {
                this.tgavg_30_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tg_50_cm_var_desc
        {
            get
            {
                return this.tg_50_cm_var_descField;
            }
            set
            {
                this.tg_50_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tg_50_cm_var_unit
        {
            get
            {
                return this.tg_50_cm_var_unitField;
            }
            set
            {
                this.tg_50_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tg_50_cm
        {
            get
            {
                return this.tg_50_cmField;
            }
            set
            {
                this.tg_50_cmField = value;
            }
        }

        /// <remarks/>
        public object tg_50_cm_state
        {
            get
            {
                return this.tg_50_cm_stateField;
            }
            set
            {
                this.tg_50_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string tgavg_50_cm_var_desc
        {
            get
            {
                return this.tgavg_50_cm_var_descField;
            }
            set
            {
                this.tgavg_50_cm_var_descField = value;
            }
        }

        /// <remarks/>
        public string tgavg_50_cm_var_unit
        {
            get
            {
                return this.tgavg_50_cm_var_unitField;
            }
            set
            {
                this.tgavg_50_cm_var_unitField = value;
            }
        }

        /// <remarks/>
        public object tgavg_50_cm
        {
            get
            {
                return this.tgavg_50_cmField;
            }
            set
            {
                this.tgavg_50_cmField = value;
            }
        }

        /// <remarks/>
        public object tgavg_50_cm_state
        {
            get
            {
                return this.tgavg_50_cm_stateField;
            }
            set
            {
                this.tgavg_50_cm_stateField = value;
            }
        }

        /// <remarks/>
        public string hhs_var_desc
        {
            get
            {
                return this.hhs_var_descField;
            }
            set
            {
                this.hhs_var_descField = value;
            }
        }

        /// <remarks/>
        public string hhs_var_unit
        {
            get
            {
                return this.hhs_var_unitField;
            }
            set
            {
                this.hhs_var_unitField = value;
            }
        }

        /// <remarks/>
        public string ns_var_desc
        {
            get
            {
                return this.ns_var_descField;
            }
            set
            {
                this.ns_var_descField = value;
            }
        }

        /// <remarks/>
        public string ns_var_unit
        {
            get
            {
                return this.ns_var_unitField;
            }
            set
            {
                this.ns_var_unitField = value;
            }
        }

        /// <remarks/>
        public object hhs1_val
        {
            get
            {
                return this.hhs1_valField;
            }
            set
            {
                this.hhs1_valField = value;
            }
        }

        /// <remarks/>
        public object hhs1_state
        {
            get
            {
                return this.hhs1_stateField;
            }
            set
            {
                this.hhs1_stateField = value;
            }
        }

        /// <remarks/>
        public object ns1_val
        {
            get
            {
                return this.ns1_valField;
            }
            set
            {
                this.ns1_valField = value;
            }
        }

        /// <remarks/>
        public object ns1_state
        {
            get
            {
                return this.ns1_stateField;
            }
            set
            {
                this.ns1_stateField = value;
            }
        }

        /// <remarks/>
        public object hhs2_val
        {
            get
            {
                return this.hhs2_valField;
            }
            set
            {
                this.hhs2_valField = value;
            }
        }

        /// <remarks/>
        public object hhs2_state
        {
            get
            {
                return this.hhs2_stateField;
            }
            set
            {
                this.hhs2_stateField = value;
            }
        }

        /// <remarks/>
        public object ns2_val
        {
            get
            {
                return this.ns2_valField;
            }
            set
            {
                this.ns2_valField = value;
            }
        }

        /// <remarks/>
        public object ns2_state
        {
            get
            {
                return this.ns2_stateField;
            }
            set
            {
                this.ns2_stateField = value;
            }
        }

        /// <remarks/>
        public object hhs3_val
        {
            get
            {
                return this.hhs3_valField;
            }
            set
            {
                this.hhs3_valField = value;
            }
        }

        /// <remarks/>
        public object hhs3_state
        {
            get
            {
                return this.hhs3_stateField;
            }
            set
            {
                this.hhs3_stateField = value;
            }
        }

        /// <remarks/>
        public object ns3_val
        {
            get
            {
                return this.ns3_valField;
            }
            set
            {
                this.ns3_valField = value;
            }
        }

        /// <remarks/>
        public object ns3_state
        {
            get
            {
                return this.ns3_stateField;
            }
            set
            {
                this.ns3_stateField = value;
            }
        }

        /// <remarks/>
        public object hhs4_val
        {
            get
            {
                return this.hhs4_valField;
            }
            set
            {
                this.hhs4_valField = value;
            }
        }

        /// <remarks/>
        public object hhs4_state
        {
            get
            {
                return this.hhs4_stateField;
            }
            set
            {
                this.hhs4_stateField = value;
            }
        }

        /// <remarks/>
        public object ns4_val
        {
            get
            {
                return this.ns4_valField;
            }
            set
            {
                this.ns4_valField = value;
            }
        }

        /// <remarks/>
        public object ns4_state
        {
            get
            {
                return this.ns4_stateField;
            }
            set
            {
                this.ns4_stateField = value;
            }
        }

        /// <remarks/>
        public decimal rrHh
        {
            get
            {
                return this.rrHhField;
            }
            set
            {
                this.rrHhField = value;
            }
        }
    }


}