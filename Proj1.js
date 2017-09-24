// JavaScript source code
var total = 0;
function Euler1() {
    for (i = 0; i < 1000; i++) {
        if ((i % 3 == 0) || (i % 5 == 0)) {
            total += i;
        }
    }
    return total;
};
alert(Euler1());