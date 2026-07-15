/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {

    var Original = init;

    var x = {
        value: init,
        increment: function() {
            this.value++;
            return this.value;
        },
        reset: function() {
            this.value = Original;
            return this.value;
        },
        decrement: function(a) {
            this.value--;
            return this.value;
        }
    };

    return x;
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */