/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function (arr, fn) {
    newArr = []
    for (let i = 0; i < arr.length; i++) {
        element = arr[i];
        if (fn(element, i)) {
            newArr.push(element);
        }
    }
    return newArr;
};
