/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function(arr, size) {
    var result = [];
    var counter = 0;

    while(counter < arr.length){
        if(arr.length - counter < size){
            size = arr.length - counter;
        }
        var temparr = []
        for(var i = 0; i < size; i++){
            temparr[i] = arr[counter];
            counter++;
        }
        result.push(temparr);
    }

    return result;
};
