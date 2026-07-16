/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function(functions) {
    
    return function(x) {
        var Z = x;
        for(var i = functions.length - 1; i >= 0; i--){
            Z = functions[i](Z)
        }
        return Z;
    }
};

/**
 * const fn = compose([x => x + 1, x => 2 * x])
 * fn(4) // 9
 */