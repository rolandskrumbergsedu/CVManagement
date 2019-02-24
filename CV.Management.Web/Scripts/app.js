$(document).ready(function () {

    function updateEducationFieldNumbers() {

        var formName = "Education";
        var fromYearFieldName = "FromYear";
        var toYearFieldName = "ToYear";
        var institutionFieldName = "Institution";
        var degreeFieldName = "Degree";

        $(".education_row").each(function (index) {

            $(this).find(".education-from-year-label").attr("for", formName + "_" + index + "__" + fromYearFieldName);
            $(this).find(".education-from-year-input").attr({
                "id": formName + "_" + index + "__" + fromYearFieldName,
                "name": formName + "[" + index + "]." + fromYearFieldName
            });
            $(this).find(".education-from-year-label").attr("data-valmsg-for", formName + "[" + index + "]." + fromYearFieldName);

            $(this).find(".education-to-year-label").attr("for", formName + "_" + index + "__" + toYearFieldName);
            $(this).find(".education-to-year-input").attr({
                "id": formName + "_" + index + "__" + toYearFieldName,
                "name": formName + "[" + index + "]." + toYearFieldName
            });
            $(this).find(".education-to-year-label").attr("data-valmsg-for", formName + "[" + index + "]." + toYearFieldName);

            $(this).find(".education-institution-label").attr("for", formName + "_" + index + "__" + institutionFieldName);
            $(this).find(".education-institution-input").attr({
                "id": formName + "_" + index + "__" + institutionFieldName,
                "name": formName + "[" + index + "]." + institutionFieldName
            });
            $(this).find(".education-institution-label").attr("data-valmsg-for", formName + "[" + index + "]." + institutionFieldName);

            $(this).find(".education-degree-label").attr("for", formName + "_" + index + "__" + degreeFieldName);
            $(this).find(".education-degree-input").attr({
                "id": formName + "_" + index + "__" + degreeFieldName,
                "name": formName + "[" + index + "]." + degreeFieldName
            });
            $(this).find(".education-degree-label").attr("data-valmsg-for", formName + "[" + index + "]." + degreeFieldName);

        });
    }
    function removeEducation() {
            $(this).closest('div[class^="education_row"]').remove();

            updateEducationFieldNumbers();
    }

    $("#education_add").click(function () {
        var existingEducationRowCount = $(".education_row").length;
        var lastEducationRow = $(".education_row").last();
        var newRow = lastEducationRow.clone();

        var formName = "Education";
        var fromYearFieldName = "FromYear";
        var toYearFieldName = "ToYear";
        var institutionFieldName = "Institution";
        var degreeFieldName = "Degree";

        newRow.find(".education-from-year-label").attr("for", formName + "_" + existingEducationRowCount + "__" + fromYearFieldName);
        newRow.find(".education-from-year-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + fromYearFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + fromYearFieldName,
            "value": null
        });
        newRow.find(".education-from-year-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + fromYearFieldName);

        newRow.find(".education-to-year-label").attr("for", formName + "_" + existingEducationRowCount + "__" + toYearFieldName);
        newRow.find(".education-to-year-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + toYearFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + toYearFieldName,
            "value": null
        });
        newRow.find(".education-to-year-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + toYearFieldName);

        newRow.find(".education-institution-label").attr("for", formName + "_" + existingEducationRowCount + "__" + institutionFieldName);
        newRow.find(".education-institution-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + institutionFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + institutionFieldName,
            "value": null
        });
        newRow.find(".education-institution-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + institutionFieldName);

        newRow.find(".education-degree-label").attr("for", formName + "_" + existingEducationRowCount + "__" + degreeFieldName);
        newRow.find(".education-degree-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + degreeFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + degreeFieldName,
            "value": null
        });
        newRow.find(".education-degree-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + degreeFieldName);

        newRow.find(".education-remove").click(removeEducation);

        $("#education_container").append(newRow);
    });

    $(".education-remove").click(removeEducation);
});