using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Management.Generation.Word
{
    public static class DocumentMetadataTexts
    {
        public static string GetText(MetadataTexts textKey, string language)
        {
            if (string.IsNullOrEmpty(language))
            {
                language = "en";
            }

            switch (textKey)
            {
                case MetadataTexts.CV_TITLE:
                    return language == "lv" ? "Konfidenciāls kandidāta CV" : "Confidential candidate CV";
                case MetadataTexts.CV_NOTICE_FIRST:
                    return language == "lv" ? "Šī atskaite satur personisku informāciju, kas iegūta konfidenciālā ceļā, tādēļ tās lietojums ir jākontrolē un strikti jālimitē tikai tām personām, kas iesaistītas kandidātu atlasē." : "This CV contains personal information obtained on a confidential basis; therefore its use should be controlled and strictly limited to designated executives concerned with the selection of the candidate.";
                case MetadataTexts.CV_NOTICE_SECOND:
                    return language == "lv" ? "Pilnīga atsauksmju pārbaude, kas apstiprinātu doto informāciju, vēl nav veikta, bet Amrop noteiktajā laikā to izdarīs. Kandidāts ir piekritis šim atlases projektam, ja tiek nodrošināta pilnīga konfidencialitāte, tāpēc bez iepriekšējas mūsu brīdināšanas neviens no Jūsu organizācijas nav tiesīgs pārbaudīt jebkādas atsauksmes par kandidātu." : "Complete references have not been taken up to substantiate the information in this report, but Amrop will do so at the appropriate stage. The candidate has agreed to discuss this opportunity on a completely confidential basis. Therefore it is imperative that any member of your organisation without our prior notification and consent check no references.";
                case MetadataTexts.CV_NOTICE_THIRD:
                    return language == "lv" ? "Bez iepriekšējas Amrop brīdināšanas, kontaktēšanās ar šo kandidātu nav atļauta." : "No contact should be made with this individual, without the prior consent of Amrop.";
                case MetadataTexts.CV_PERSONAL:
                    return language == "lv" ? "Personīgā informācija" : "Personal";
                case MetadataTexts.CV_NAME_SURNAME:
                    return language == "lv" ? "Vārds, Uzvārds" : "Name, Surname";
                case MetadataTexts.CV_ADDRESS:
                    return language == "lv" ? "Adrese" : "Address";
                case MetadataTexts.CV_MOBILE:
                    return language == "lv" ? "Telefons (mobilais)" : "Mobile";
                case MetadataTexts.CV_EMAIL:
                    return language == "lv" ? "E-pasts" : "E-mail";
                case MetadataTexts.CV_OTHER_INFORMATION:
                    return language == "lv" ? "Cita informācija" : "Other information";
                case MetadataTexts.CV_LINKEDIN_LINK:
                    return language == "lv" ? "LinkedIn profile hipersaite" : "LinkedIn profile link";
                case MetadataTexts.CV_EDUCATION:
                    return language == "lv" ? "Izglītība" : "Education and qualifications";
                case MetadataTexts.CV_ADDITIONAL_COURSES:
                    return language == "lv" ? "Papildus apmācības" : "Additional courses";
                case MetadataTexts.CV_DAY:
                    return language == "lv" ? "diena" : "day";
                case MetadataTexts.CV_DAYS:
                    return language == "lv" ? "dienas" : "days";
                case MetadataTexts.CV_LANGUAGE:
                    return language == "lv" ? "Valoda" : "Language";
                case MetadataTexts.CV_LANGUAGE_SPOKEN:
                    return language == "lv" ? "Mutvārdos" : "Spoken";
                case MetadataTexts.CV_LANGUAGE_WRITTEN:
                    return language == "lv" ? "Rakstiski" : "Written";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY:
                    return language == "lv" ? "Valodu zināšanas" : "Language proficiency";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY_LEVEL:
                    return language == "lv" ? "Zināšanu līmenis" : "Proficiency level";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY_BASIC:
                    return language == "lv" ? "pamata" : "basic";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY_SATISFACTORY:
                    return language == "lv" ? "viduvēji" : "satisfactory";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY_GOOD:
                    return language == "lv" ? "labi" : "good";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY_EXCELLENT:
                    return language == "lv" ? "brīvi" : "excellent";
                case MetadataTexts.CV_LANGUAGE_PROFICIENCY_NATIVE:
                    return language == "lv" ? "dzimtā" : "native";
                case MetadataTexts.CV_CAREER_SUMMARY:
                    return language == "lv" ? "Darba pieredze" : "Career summary";
                case MetadataTexts.CV_COMPANY_INFORMATION:
                    return language == "lv" ? "Informācija par uzņēmumu" : "Company information";
                case MetadataTexts.CV_COMPANY_CITY:
                    return language == "lv" ? "Pilsēta" : "City";
                case MetadataTexts.CV_COMPANY_PARENT_COMPANY:
                    return language == "lv" ? "Mātes kompānija" : "Parent company";
                case MetadataTexts.CV_COMPANY_INDUSTRY:
                    return language == "lv" ? "Industrija/darbības sfēras" : "Industry";
                case MetadataTexts.CV_COMPANY_SERVICES:
                    return language == "lv" ? "Galvenie produkti/pakalpojumi" : "Services";
                case MetadataTexts.CV_COMPANY_TURNOVER:
                    return language == "lv" ? "Apgrozījums" : "Turnover";
                case MetadataTexts.CV_COMPANY_EMPLOYEES:
                    return language == "lv" ? "Darbinieku skaits" : "Number of employees";
                case MetadataTexts.CV_TASK_INFORMATION:
                    return language == "lv" ? "Amats" : "Task information";
                case MetadataTexts.CV_POSITION_REPORTING_TO:
                    return language == "lv" ? "Atskaitīšanās" : "Reporting to";
                case MetadataTexts.CV_POSTION_SUBORDINATES:
                    return language == "lv" ? "Tieši un netieši pakļautībā esošie" : "Subordinates";
                case MetadataTexts.CV_POSITION_ACHIEVEMENTS:
                    return language == "lv" ? "Sasniegumi" : "Achievements";
                case MetadataTexts.CV_POSITION_REASON_FOR_LEAVING:
                    return language == "lv" ? "Aziešanas iemesls" : "Reason for leaving";
                case MetadataTexts.CV_PRESENT:
                    return language == "lv" ? "pašlaik" : "present";
                case MetadataTexts.CV_SOCIAL_ACTIVITIES:
                    return language == "lv" ? "Sociālās aktivitātes / līdzdalība citās organizācijās" : "Social activities / Memberships";
                case MetadataTexts.CV_COMPENSATION:
                    return language == "lv" ? "Atalgojums" : "Compensation";
                case MetadataTexts.CV_COMPENSATION_CURRENT_SALARY:
                    return language == "lv" ? "Esošais fiksētais atalgojums (bruto)" : "Current salary (gross)";
                case MetadataTexts.CV_COMPENSATION_CURRENT_BONUSES:
                    return language == "lv" ? "Esošie labumi" : "Current bonuses";
                case MetadataTexts.CV_COMPENSATION_REQUESTED_SALARY:
                    return language == "lv" ? "Vēlamais filsētais atalgojums (bruto)" : "Requested salary (gross)";
                case MetadataTexts.CV_COMPENSATION_REQUESTED_BONUSES:
                    return language == "lv" ? "Vēlamie labumi" : "Requested bonuses";
                case MetadataTexts.CV_COMPENSATION_ADDITIONAL_BONUSES:
                    return language == "lv" ? "Papildus labumi" : "Additional bonuses";
                case MetadataTexts.CV_TRANSITION_TIME:
                    return language == "lv" ? "Pārejas periods" : "Transition time";
                case MetadataTexts.CV_NOTICE_PERIOD:
                    return language == "lv" ? "Pārejas periods aiziešanai no šī brīža darba vietas" : "Notice period leaving current employer";
                case MetadataTexts.CV_ADDITIONAL_COMMENTS:
                    return language == "lv" ? "Papildus komentāri" : "Additional comments";
                case MetadataTexts.CV_MONTH_JANUARY:
                    return language == "lv" ? "Janvāris" : "January";
                case MetadataTexts.CV_MONTH_FEBRUARY:
                    return language == "lv" ? "Februāris" : "February";
                case MetadataTexts.CV_MONTH_MARCH:
                    return language == "lv" ? "Marts" : "March";
                case MetadataTexts.CV_MONTH_APRIL:
                    return language == "lv" ? "Aprīlis" : "April";
                case MetadataTexts.CV_MONTH_MAY:
                    return language == "lv" ? "Maijs" : "May";
                case MetadataTexts.CV_MONTH_JUNE:
                    return language == "lv" ? "Jūnijs" : "June";
                case MetadataTexts.CV_MONTH_JULY:
                    return language == "lv" ? "Jūlijs" : "July";
                case MetadataTexts.CV_MONTH_AUGUST:
                    return language == "lv" ? "Augusts" : "August";
                case MetadataTexts.CV_MONTH_SEPTEMBER:
                    return language == "lv" ? "Septembris" : "September";
                case MetadataTexts.CV_MONTH_OCTOBER:
                    return language == "lv" ? "Oktobris" : "October";
                case MetadataTexts.CV_MONTH_NOVEMBER:
                    return language == "lv" ? "Novembris" : "November";
                case MetadataTexts.CV_MONTH_DECEMBER:
                    return language == "lv" ? "Decembris" : "December";
                default:
                    throw new Exception($"Could not find the text {textKey}!");
            }
        }

    }
}
