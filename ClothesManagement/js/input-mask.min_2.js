!function(t){"use strict";var e=function(e,n,a){var r,o=this;e=t(e),n="function"==typeof n?n(e.val(),void 0,e,a):n,o.init=function(){a=a||{},o.byPassKeys=[9,16,17,18,36,37,38,39,40,91],o.translation={0:{pattern:/\d/},9:{pattern:/\d/,optional:!0},"#":{pattern:/\d/,recursive:!0},A:{pattern:/[a-zA-Z0-9]/},S:{pattern:/[a-zA-Z]/}},o.translation=t.extend({},o.translation,a.translation),o=t.extend(!0,{},o,a),e.each(function(){a.maxlength!==!1&&e.attr("maxlength",n.length),e.attr("autocomplete","off"),s.destroyEvents(),s.events(),s.val(s.getMasked())})};var s={getCaret:function(){var t,n=0,a=e.get(0),r=document.selection,o=a.selectionStart;return r&&-1===navigator.appVersion.indexOf("MSIE 10")?(a.focus(),t=r.createRange(),t.moveStart("character",-a.value.length),n=t.text.length):(o||"0"===o)&&(n=o),n},setCaret:function(t){var n,a=e.get(0);a.setSelectionRange?(a.focus(),a.setSelectionRange(t,t)):a.createTextRange&&(n=a.createTextRange(),n.collapse(!0),n.moveEnd("character",t),n.moveStart("character",t),n.select())},events:function(){e.on("keydown.mask",function(){r=s.val()}),e.on("keyup.mask",s.behaviour),e.on("paste.mask",function(){setTimeout(function(){e.keydown().keyup()},100)})},destroyEvents:function(){e.off("keydown.mask keyup.mask paste.mask")},val:function(t){var n="input"===e.get(0).tagName.toLowerCase();return arguments.length>0?n?e.val(t):e.text(t):n?e.val():e.text()},behaviour:function(e){if(e=e||window.event,-1===t.inArray(e.keyCode||e.which,o.byPassKeys)){var n,a=s.getCaret();return a<s.val().length&&(n=!0),s.val(s.getMasked()),n&&s.setCaret(a),s.callbacks(e)}},getMasked:function(t){var e,r,i=[],c=s.val(),u=0,l=n.length,f=0,v=c.length,h=1,g="push",m=-1;for(a.reverse?(g="unshift",h=-1,e=0,u=l-1,f=v-1,r=function(){return u>-1&&f>-1}):(e=l-1,r=function(){return l>u&&v>f});r();){var d=n.charAt(u),k=c.charAt(f),p=o.translation[d];p?(k.match(p.pattern)?(i[g](k),p.recursive&&(-1===m?m=u:u===e&&(u=m-h),e===m&&(u-=h)),u+=h):p.optional&&(u+=h,f-=h),f+=h):(t||i[g](d),k===d&&(f+=h),u+=h)}var y=n.charAt(e);return l!==v+1||o.translation[y]||i.push(y),i.join("")},callbacks:function(t){var o=s.val(),i=s.val()!==r;i===!0&&"function"==typeof a.onChange&&a.onChange(o,t,e,a),i===!0&&"function"==typeof a.onKeyPress&&a.onKeyPress(o,t,e,a),"function"==typeof a.onComplete&&o.length===n.length&&a.onComplete(o,t,e,a)}};o.remove=function(){s.destroyEvents(),s.val(o.getCleanVal()).removeAttr("maxlength")},o.getCleanVal=function(){return s.getMasked(!0)},o.init()};t.fn.mask=function(n,a){return this.each(function(){t(this).data("mask",new e(this,n,a))})},t.fn.unmask=function(){return this.each(function(){try{t(this).data("mask").remove()}catch(e){}})},t.fn.cleanVal=function(){return t(this).data("mask").getCleanVal()},t("*[data-mask]").each(function(){var e=t(this),n={};"true"===e.attr("data-mask-reverse")&&(n.reverse=!0),"false"===e.attr("data-mask-maxlength")&&(n.maxlength=!1),e.mask(e.attr("data-mask"),n)})}(window.jQuery||window.Zepto);