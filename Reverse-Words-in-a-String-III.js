/**
 * @param {string} s
 * @return {string}
 */
var reverseWords = function(s="") {
    var Temp = [];
    Temp = s.split(' ');
    for(let i = 0; i < Temp.length; i++){
        var temp2 = [];
        temp2 = Temp[i].split('');
        temp2.reverse();
        Temp[i] = temp2.join('');
    }
    return Temp.join(" ");
};