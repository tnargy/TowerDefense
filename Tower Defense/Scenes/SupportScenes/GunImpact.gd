extends AnimatedSprite


func _ready():
	_set_playing(true)
	

func _on_GunImpact_animation_finished():
	queue_free()
