function OnOff(lol){ ///�W���̃y�[�W�̏ꍇ�̕������B��&�\�������鏈��
	if (lol.value == "�����������B��") {
	    lol.value = "�B����������\������";
	    $("b").css({ "color": "#252525" });
	    location.href = "#";
	} else {
	    lol.value = "�����������B��";
	    $("b").css({ "color": "#ffff00" });
	    location.href = "#";
	}
}

function syokipage_kakusu() { ///�����y�[�W�ł̏ꍇ�̕������B������
    $("b").css({ "color": "#252525" });
}

function syokipage_hyouji() { ///�����y�[�W�ł̏ꍇ�̕�����\�������鏈��
    $("b").css({ "color": "#ffff00" });
}