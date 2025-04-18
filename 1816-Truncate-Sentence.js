/**
 * @param {string} s
 * @param {number} k
 * @return {string}
 */
var truncateSentence = function(s, k) {
    let TempArr = s.split(" ");
    TempArr.splice(k);
    
    return TempArr.join(" ");
};
