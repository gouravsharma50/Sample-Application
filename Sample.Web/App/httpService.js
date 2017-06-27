
var service = function () {

    function Get(url, obj, callback) {
        $.get(url, obj, callback);
    }

    function GetJson(url, obj, callback) {
        $.getJSON(url, obj, callback);
    }

    function Post(url, obj, callBack) {
        $.post(url, obj, callBack);
    }
}