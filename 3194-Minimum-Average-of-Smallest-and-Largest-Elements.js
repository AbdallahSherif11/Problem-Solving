/**
 * @param {number[]} nums
 * @return {number}
 */
var minimumAverage = function(nums=[]) {
    var avgs = [];
    var temp = nums.length /2;
    for (let i = 0; i < temp; i++)
    {
        avgs[i] = ((Math.min(...nums) + Math.max(...nums)) / 2);
        nums.splice(nums.indexOf(Math.min(...nums)),1);
        nums.splice(nums.indexOf(Math.max(...nums)),1);
    }
    return Math.min(...avgs);
};
