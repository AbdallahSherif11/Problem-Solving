/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function(arr, fn) {
    var Result = [];
    for(var i = 0; i < arr.length; i++){
        if(fn(arr[i]) || fn(arr[i],i)){
            Result.push(arr[i])
        }
    }
    return Result;
};