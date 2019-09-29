function OnOff(lol){ ///標準のページの場合の文字を隠す&表示させる処理
	if (lol.value == "太字部分を隠す") {
	    lol.value = "隠した部分を表示する";
	    $("b").css({ "color": "#252525" });
	    location.href = "#";
	} else {
	    lol.value = "太字部分を隠す";
	    $("b").css({ "color": "#ffff00" });
	    location.href = "#";
	}
}

function syokipage_kakusu() { ///初期ページでの場合の文字を隠す処理
    $("b").css({ "color": "#252525" });
}

function syokipage_hyouji() { ///初期ページでの場合の文字を表示させる処理
    $("b").css({ "color": "#ffff00" });
}