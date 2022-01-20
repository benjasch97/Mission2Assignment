$("#calc").click(function () {


    // calculates the percent score based on the inputs from the GradeCalc form view page
    percent = Math.round(($("#txtAssignment").val() * 0.55) + ($("#txtGroup").val() * 0.05) + ($("#txtQuiz").val() * 0.1) +
        ($("#txtExam").val() * 0.2) + ($("#txtINTEX").val() * 0.1));

    // determines the letter grade based on the percent grade
    if (percent > 93) {
        letter = 'A'
    } else if (percent > 89) {
        letter = 'A-'
    } else if (percent > 86) {
        letter = 'B+'
    } else if (percent > 83) {
        letter = 'B'
    } else if (percent > 79) {
        letter = 'B-'
    } else if (percent > 76) {
        letter = 'C+'
    } else if (percent > 73) {
        letter = 'C'
    } else if (percent > 69) {
        letter = 'C-'
    } else if (percent > 66) {
        letter = 'D+'
    } else if (percent > 63) {
        letter = 'D'
    } else if (percent > 59) {
        letter = 'D-'
    } else {
        letter = 'F'
    }

    // outputs the final grade percentage and letter grade in an alert box
    alert("Final grade percentage: " + percent + "%." + "\nFinal letter grade: " + letter + ".");
})