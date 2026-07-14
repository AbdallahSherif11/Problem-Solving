/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function(nums, fn, init) {

    var Temp = init;
    var x = 0

    for(var i = 0; i < nums.length; i++){
        Temp = fn(Temp,nums[i])

    }
    
    return Temp;
};