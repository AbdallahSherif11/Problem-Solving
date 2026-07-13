/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function(arr, fn) {
    var Result = []
    for(var i = 0; i < arr.length; i++){
        Result.push(fn(arr[i],i));
    }
    return Result;
};