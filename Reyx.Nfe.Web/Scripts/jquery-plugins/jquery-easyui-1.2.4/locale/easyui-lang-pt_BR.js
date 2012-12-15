if ($.fn.pagination){
	$.fn.pagination.defaults.beforePageText = 'Página';
	$.fn.pagination.defaults.afterPageText = 'de {pages}';
	$.fn.pagination.defaults.displayMsg = '{from} - {to} de {total}';
}
if ($.fn.datagrid){
	$.fn.datagrid.defaults.loadMsg = 'Aguarde...';
}
if ($.fn.treegrid && $.fn.datagrid){
	$.fn.treegrid.defaults.loadMsg = $.fn.datagrid.defaults.loadMsg;
}
if ($.messager){
	$.messager.defaults.ok = 'Ok';
	$.messager.defaults.cancel = 'Cancelar';
}
if ($.fn.validatebox){
	$.fn.validatebox.defaults.missingMessage = 'Campo Obrigatório.';
	$.fn.validatebox.defaults.rules.email.message = 'Please enter a valid email address.';
	$.fn.validatebox.defaults.rules.url.message = 'Please enter a valid URL.';
	$.fn.validatebox.defaults.rules.length.message = 'Please enter a value between {0} and {1}.';
	$.fn.validatebox.defaults.rules.remote.message = 'Please fix this field.';
}
if ($.fn.numberbox){
	$.fn.numberbox.defaults.missingMessage = 'Campo Obrigatório.';
}
if ($.fn.combobox){
	$.fn.combobox.defaults.missingMessage = 'Campo Obrigatório.';
}
if ($.fn.combotree){
	$.fn.combotree.defaults.missingMessage = 'Campo Obrigatório.';
}
if ($.fn.combogrid){
	$.fn.combogrid.defaults.missingMessage = 'Campo Obrigatório.';
}
if ($.fn.calendar){
	$.fn.calendar.defaults.weeks = ['S','M','T','W','T','F','S'];
	$.fn.calendar.defaults.months = ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'A'o, 'Set', 'Out', 'Nov', 'Dez'];
}
if ($.fn.datebox){
	$.fn.datebox.defaults.currentText = 'Hoje';
	$.fn.datebox.defaults.closeText = 'Fechar';
	$.fn.datebox.defaults.okText = 'Ok';
	$.fn.datebox.defaults.missingMessage = 'Campo Obrigatório.';
}
if ($.fn.datetimebox && $.fn.datebox){
	$.extend($.fn.datetimebox.defaults,{
		currentText: $.fn.datebox.defaults.currentText,
		closeText: $.fn.datebox.defaults.closeText,
		okText: $.fn.datebox.defaults.okText,
		missingMessage: $.fn.datebox.defaults.missingMessage
	});
}
