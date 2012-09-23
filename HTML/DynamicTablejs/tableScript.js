function addRow(){
	var currentTable=document.getElementById("table").innerHTML();
	var newTable;
	
	var list = document.getElementById("projectNumber");
	var projectNumber = list.options[list.selectedIndex].text;
	newTable += currentTable;
	newtable += "<tr><td>" + projectNumber + "</td></tr>";
	alert("Selected Project Number" + projectNumber);
	document.getElementById("table").innerHTML=newTable;
}
function addRowToTable()
{
  var tbl = document.getElementById('tblSample');
  var lastRow = tbl.rows.length;
  var projectNumber, date, hours;
  var list = document.getElementById("projectNumber");
  projectNumber = list.options[list.selectedIndex].text;
  date = document.getElementById('dateForHours').value;
  hours = document.getElementById('hours').value;
  
  // if there's no header row in the table, then iteration = lastRow + 1
  var iteration = lastRow;
  var row = tbl.insertRow(lastRow);
  
  // Number cell
  var cellNumber = row.insertCell(0);
  var textNode = document.createTextNode(iteration);
  cellNumber.appendChild(textNode);
  
  //Project Number Cell
  var cellProjectNumber = row.insertCell(1);
  var textNode2 = document.createTextNode(projectNumber);
  cellProjectNumber.appendChild(textNode2);
  
  
  // right cell
  var cellDate = row.insertCell(2);
  var el = document.createTextNode(date)
  cellDate.appendChild(el);  
  
  //
  var cellHours = row.insertCell(3);
  var textNode3 = document.createTextNode(hours);
  cellHours.appendChild(textNode3);
 }

function removeRowFromTable()
{
  var tbl = document.getElementById('tblSample');
  var lastRow = tbl.rows.length;
  if (lastRow > 2) tbl.deleteRow(lastRow - 1);
}