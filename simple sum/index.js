function buttonClicked() {

    var num1 = document.getElementById('number1').value;
    num1 = parseInt(num1);

    var num2 = document.getElementById('number2').value;
    num2 = parseInt(num2);

    var result = num1 + num2;
    document.getElementById('result').value = result;
}
function buttonClicked1() {

    var num3 = document.getElementById('number3').value;
    num3 = parseInt(num3);

    var num4 = document.getElementById('number4').value;
    num4 = parseInt(num4);

    var result = num3 - num4;
    document.getElementById('result').value = result;
}
