
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_565

	''' <summary>
	'''     Retrieves a reference to a specified .
	''' </summary>
	''' <param name="str">The string to search for in the intern pool.</param>
	''' <returns>A reference to  if it is in the common language runtime intern pool; otherwise, null.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsInterned(str As [String]) As [String]
		Return [String].IsInterned(str)
	End Function
End Module


