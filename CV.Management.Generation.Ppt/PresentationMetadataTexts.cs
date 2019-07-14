using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Management.Generation.Ppt
{
    public static class PresentationMetadataTexts
    {
        public static string GetText(PresentationMetadataTextsEnum textKey, string language)
        {
            if (string.IsNullOrEmpty(language))
            {
                language = "en";
            }

            switch (textKey)
            {
                case PresentationMetadataTextsEnum.PHONE:
                    return language == "lv" ? "Tālrunis" : "Phone";
                case PresentationMetadataTextsEnum.EMAIL:
                    return language == "lv" ? "E-pasts" : "Email";
                case PresentationMetadataTextsEnum.CV_MONTH_JANUARY:
                    return language == "lv" ? "Janvāris" : "January";
                case PresentationMetadataTextsEnum.CV_MONTH_FEBRUARY:
                    return language == "lv" ? "Februāris" : "February";
                case PresentationMetadataTextsEnum.CV_MONTH_MARCH:
                    return language == "lv" ? "Marts" : "March";
                case PresentationMetadataTextsEnum.CV_MONTH_APRIL:
                    return language == "lv" ? "Aprīlis" : "April";
                case PresentationMetadataTextsEnum.CV_MONTH_MAY:
                    return language == "lv" ? "Maijs" : "May";
                case PresentationMetadataTextsEnum.CV_MONTH_JUNE:
                    return language == "lv" ? "Jūnijs" : "June";
                case PresentationMetadataTextsEnum.CV_MONTH_JULY:
                    return language == "lv" ? "Jūlijs" : "July";
                case PresentationMetadataTextsEnum.CV_MONTH_AUGUST:
                    return language == "lv" ? "Augusts" : "August";
                case PresentationMetadataTextsEnum.CV_MONTH_SEPTEMBER:
                    return language == "lv" ? "Septembris" : "September";
                case PresentationMetadataTextsEnum.CV_MONTH_OCTOBER:
                    return language == "lv" ? "Oktobris" : "October";
                case PresentationMetadataTextsEnum.CV_MONTH_NOVEMBER:
                    return language == "lv" ? "Novembris" : "November";
                case PresentationMetadataTextsEnum.CV_MONTH_DECEMBER:
                    return language == "lv" ? "Decembris" : "December";
                case PresentationMetadataTextsEnum.PRESENT:
                    return language == "lv" ? "Šobrīd" : "Present";
                case PresentationMetadataTextsEnum.RENUMERATION:
                    return language == "lv" ? "Vēlamais atalgojums" : "Renumeration";
                case PresentationMetadataTextsEnum.REQUESTED_BONUSES:
                    return language == "lv" ? "Vēlamie labumi" : "Requested bonuses";
                case PresentationMetadataTextsEnum.ADDITIONAL_BONUSES:
                    return language == "lv" ? "Papildus labumi" : "Additional bonuses";
                case PresentationMetadataTextsEnum.EXPERIENCE:
                    return language == "lv" ? "Pieredze" : "Experience";
                case PresentationMetadataTextsEnum.EDUCATION:
                    return language == "lv" ? "Izglītība" : "Education";
                case PresentationMetadataTextsEnum.LANGUAGES:
                    return language == "lv" ? "Valodu zināšanas" : "Languages";
                case PresentationMetadataTextsEnum.STRENGTHS:
                    return language == "lv" ? "Stiprās un vājās puses" : "Strengths & weaknesses";
                case PresentationMetadataTextsEnum.MOTIVATION:
                    return language == "lv" ? "Motivācija" : "Motivation";
                default:
                    throw new Exception($"Could not find the text {textKey.ToString()}!");
            }
        }

    }
}
