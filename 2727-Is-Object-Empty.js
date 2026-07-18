/**
 * @param {Object|Array} obj
 * @return {boolean}
 */
var isEmpty = function(obj) {
    if(typeof obj === 'object' && obj !== null && !Array.isArray(obj)){
        if(Object.keys(obj).length == 0){
            return true;
        }
    }
    if(Array.isArray(obj)){
        if(obj.length == 0){
            return true;
        }
    }
    return false;
};