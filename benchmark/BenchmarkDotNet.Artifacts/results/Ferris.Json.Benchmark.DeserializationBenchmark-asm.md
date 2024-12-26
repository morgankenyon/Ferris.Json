## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.DeserializationBenchmark.FerrisValueMapping()
       push      rsi
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rdx,1E341C04188
       mov       rdx,[rdx]
       test      rdx,rdx
       jne       short M00_L00
       xor       r8d,r8d
       xor       ecx,ecx
       jmp       short M00_L01
M00_L00:
       lea       r8,[rdx+0C]
       mov       ecx,[rdx+8]
M00_L01:
       mov       [rsp+20],r8
       mov       [rsp+28],ecx
       mov       rdx,1E300208750
       lea       r8,[rsp+20]
       lea       rcx,[rsp+30]
       call      qword ptr [7FFC8DE9FEA0]; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
       call      qword ptr [7FFC8DBF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       r8,rax
       mov       rdx,1E300208750
       mov       rcx,[rsp+30]
       call      qword ptr [7FFC8DEC40F0]; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       mov       r8,rax
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.StringPropertyObj
       cmp       [r8],rcx
       je        short M00_L02
       mov       rdx,rax
       call      qword ptr [7FFC8DAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L02:
       mov       esi,[rbx+8]
       mov       rcx,[r8+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,0EA9DFC78
       mov       r9d,438637D9
       call      qword ptr [7FFC8DEC7B88]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 210
```
```assembly
; Ferris.Json.JsonTransformer.Deserialize(System.Type, System.ReadOnlySpan`1<Char>)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,268
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L01:
       vmovdqa   xmmword ptr [rsp+rax+250],xmm4
       vmovdqa   xmmword ptr [rsp+rax+260],xmm4
       vmovdqa   xmmword ptr [rsp+rax+270],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rsp+250],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[r8]
       mov       ebp,[r8+8]
       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.Object, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1E341C01E98
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rbx],rdx
       jne       near ptr M01_L61
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+1E8]
       mov       rcx,rbx
       xor       r8d,r8d
       mov       r9d,14
       call      qword ptr [7FFC8D9F66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+1F8],0
       je        near ptr M01_L59
       cmp       dword ptr [rsp+1F8],1
       jne       near ptr M01_L60
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rsp+1F0]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L02:
       mov       rcx,1E341C04E70
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M01_L44
M01_L03:
       mov       rcx,1E341C04E78
       mov       r9,[rcx]
       test      r9,r9
       je        short M01_L05
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r15
       mov       r8,r13
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>, System.Func`2<System.Reflection.PropertyInfo,System.Reflection.PropertyInfo>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFC8DEC7000]; System.Linq.Enumerable.ToDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Func`2<System.__Canon,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r15,rax
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M01_L65
       mov       rcx,rbx
       jmp       near ptr M01_L45
M01_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1E341C04E68
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC8DEC27F0
       mov       [r12+18],rcx
       mov       rcx,1E341C04E78
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r12
       jmp       near ptr M01_L04
M01_L06:
       mov       r12d,1
M01_L07:
       mov       rbx,rdi
       mov       eax,ebp
       test      eax,eax
       je        near ptr M01_L68
       movzx     r10d,word ptr [rbx]
       cmp       r10d,7B
       je        near ptr M01_L43
       cmp       r10d,7D
       je        near ptr M01_L39
       cmp       r10d,22
       jne       near ptr M01_L14
       cmp       r12d,9
       jne       near ptr M01_L11
       mov       r9d,7
M01_L08:
       mov       r11d,r9d
       mov       [rsp+1E4],r11d
       cmp       r11d,6
       je        short M01_L09
       cmp       r11d,7
       jne       near ptr M01_L42
M01_L09:
       cmp       r11d,6
       jne       near ptr M01_L46
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1B8],xmm0
       cmp       eax,1
       jb        near ptr M01_L58
       add       rbx,2
       sub       eax,1
       mov       [rsp+0C8],eax
       mov       edx,22
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFC8DD356C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+1CC],eax
       cmp       eax,[rsp+0C8]
       ja        near ptr M01_L58
       mov       [rsp+1B8],rbx
       mov       [rsp+1C0],eax
       lea       rcx,[rsp+1B8]
       call      qword ptr [7FFC8DB5C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       ebx,[rsp+1CC]
       add       ebx,2
       mov       [rsp+1D0],rax
       mov       [rsp+1D8],ebx
M01_L10:
       mov       rbx,[rsp+1D0]
       mov       eax,[rsp+1D8]
       mov       r8d,[rsp+1E4]
       jmp       short M01_L13
M01_L11:
       mov       r9d,6
       jmp       near ptr M01_L08
M01_L12:
       mov       r8d,r11d
       xor       ebx,ebx
       mov       eax,r8d
       mov       r10d,1
       mov       r8d,eax
       mov       eax,r10d
M01_L13:
       mov       r10d,r8d
       mov       [rsp+264],r10d
       mov       [rsp+260],eax
       cmp       r10d,2
       je        near ptr M01_L49
       jmp       short M01_L15
M01_L14:
       cmp       r10d,3A
       jne       near ptr M01_L62
       mov       r9d,9
       jmp       near ptr M01_L08
M01_L15:
       cmp       r10d,8
       je        short M01_L16
       cmp       r10d,5
       jne       near ptr M01_L34
       mov       r10d,[rsp+264]
M01_L16:
       cmp       r12d,7
       jne       near ptr M01_L32
       mov       ecx,[r14+10]
       dec       ecx
       mov       [rsp+9C],ecx
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8,rax
       mov       r11d,[r8+8]
       cmp       r11d,edx
       jbe       near ptr M01_L57
       mov       ecx,[r14+14]
       inc       ecx
       mov       [rsp+98],ecx
       mov       [r14+14],ecx
       mov       [r14+10],edx
       shl       rdx,4
       lea       rdx,[r8+rdx+10]
       mov       r8,rdx
       mov       r8,[r8]
       mov       [rsp+38],r8
       xor       r8d,r8d
       mov       [rdx],r8
       mov       [rdx+8],r8
       mov       r8,[rsp+38]
       mov       [rsp+88],r8
       mov       edx,[rsp+9C]
       dec       edx
       mov       [rsp+94],edx
       mov       [rsp+78],rax
       cmp       r11d,edx
       jbe       near ptr M01_L57
       mov       ecx,[rsp+98]
       inc       ecx
       mov       [rsp+90],ecx
       mov       [r14+14],ecx
       mov       [r14+10],edx
       cmp       edx,r11d
       jae       near ptr M01_L93
       shl       rdx,4
       mov       rcx,[rsp+78]
       lea       rcx,[rcx+rdx+10]
       mov       rdx,rcx
       cmp       [rdx],edx
       mov       edx,[rdx+8]
       mov       [rsp+0C0],edx
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rcx+8],rdx
       mov       edx,[rsp+0C0]
       mov       [rsp+0CC],edx
       mov       ecx,[rsp+94]
       dec       ecx
       cmp       r11d,ecx
       jbe       near ptr M01_L57
       mov       edx,[rsp+90]
       inc       edx
       mov       [r14+14],edx
       mov       [r14+10],ecx
       cmp       ecx,r11d
       jae       near ptr M01_L93
       shl       rcx,4
       lea       rcx,[rax+rcx+10]
       mov       rdx,rcx
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       xor       r11d,r11d
       mov       [rcx],r11
       mov       [rcx+8],r11
       cmp       dword ptr [rsp+0CC],9
       jne       near ptr M01_L31
       cmp       edx,6
       jne       near ptr M01_L30
       test      r8,r8
       je        near ptr M01_L29
       test      rax,rax
       je        near ptr M01_L28
       mov       rdx,rax
       mov       rcx,offset MT_System.String
       cmp       [rdx],rcx
       jne       near ptr M01_L51
       cmp       [r15],r15b
       mov       rcx,r15
       call      qword ptr [7FFC8DAAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L34
       mov       rax,[rax]
       xor       ecx,ecx
       mov       [rsp+108],ecx
       mov       [rsp+110],ecx
       mov       [rsp+11C],ecx
       mov       [rsp+120],rcx
       mov       byte ptr [rsp+128],0
       mov       byte ptr [rsp+130],0
       mov       byte ptr [rsp+138],0
       mov       [rsp+140],ecx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+148],xmm0
       mov       [rsp+158],rcx
       mov       [rsp+160],rcx
       vmovups   [rsp+168],xmm0
       vmovups   [rsp+178],xmm0
       mov       [rsp+188],ecx
       mov       [rsp+190],ecx
       mov       [rsp+198],rcx
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rax],rcx
       jne       near ptr M01_L72
       mov       rcx,rax
       cmp       qword ptr [rcx+38],0
       je        near ptr M01_L37
M01_L17:
       mov       rcx,[rax+38]
       mov       rdx,[rcx+18]
M01_L18:
       mov       r8,rdx
       mov       [rsp+68],r8
       mov       rcx,1E300200020
       cmp       r8,rcx
       jne       near ptr M01_L73
M01_L19:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rax],rcx
       jne       near ptr M01_L76
       cmp       qword ptr [rax+20],0
       je        near ptr M01_L74
       mov       rax,[rax+20]
M01_L20:
       mov       r10,rax
       mov       [rsp+50],r10
       test      r10,r10
       je        near ptr M01_L52
       cmp       qword ptr [r10+48],0
       je        near ptr M01_L36
M01_L21:
       mov       r10,[rsp+50]
       mov       rcx,[r10+48]
       test      dword ptr [rcx+3C],102
       je        near ptr M01_L27
       mov       rcx,r10
       call      qword ptr [7FFC8DCA5860]
M01_L22:
       mov       rax,[rsp+50]
       test      byte ptr [rax+5C],10
       jne       short M01_L24
       mov       rcx,[rax+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M01_L75
       mov       rcx,[rax+38]
M01_L23:
       mov       rdx,r13
       mov       r8,[rcx]
       mov       r8,[r8+0A0]
       call      qword ptr [r8+8]
       test      eax,eax
       mov       rax,[rsp+50]
       je        near ptr M01_L53
M01_L24:
       mov       rdx,[rax+30]
       test      rdx,rdx
       je        near ptr M01_L35
M01_L25:
       mov       rcx,[rdx+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M01_L54
       cmp       qword ptr [rax+48],0
       je        short M01_L33
M01_L26:
       mov       r10,[rsp+88]
       mov       [rsp+20],r10
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       rax,[rsp+50]
       mov       rcx,[rax+48]
       mov       rdx,r13
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DCA7930]; System.Reflection.MethodBaseInvoker.InvokePropertySetter(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object, System.Globalization.CultureInfo)
       jmp       short M01_L34
M01_L27:
       jmp       near ptr M01_L22
M01_L28:
       jmp       short M01_L34
M01_L29:
       jmp       short M01_L34
M01_L30:
       jmp       short M01_L34
M01_L31:
       jmp       short M01_L34
M01_L32:
       jmp       short M01_L34
M01_L33:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       mov       rcx,rax
       mov       rdx,[rsp+50]
       call      qword ptr [7FFC8DCA7810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       mov       rax,[rsp+50]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L26
M01_L34:
       mov       r10d,[rsp+264]
       cmp       r10d,4
       jne       near ptr M01_L38
       jmp       near ptr M01_L50
M01_L35:
       mov       rcx,rax
       call      qword ptr [7FFC8DCA5890]; System.Reflection.RuntimeMethodInfo.<get_Signature>g__LazyCreateSignature|25_0()
       mov       rdx,rax
       mov       rax,[rsp+50]
       jmp       near ptr M01_L25
M01_L36:
       mov       rcx,offset MT_System.Reflection.MethodBaseInvoker
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,rax
       mov       rdx,[rsp+50]
       call      qword ptr [7FFC8DCA7810]; System.Reflection.MethodBaseInvoker..ctor(System.Reflection.RuntimeMethodInfo)
       mov       rax,[rsp+50]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L21
M01_L37:
       mov       [rsp+70],rax
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       [rsp+58],rax
       cmp       [rax],al
       mov       rcx,rax
       call      System.ModuleHandle._GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rdx,[rsp+58]
       mov       [rsp+0F8],rdx
       mov       [rsp+100],rax
       lea       rdx,[rsp+0D8]
       mov       [rsp+20],rdx
       mov       rax,[rsp+70]
       mov       edx,[rax+50]
       lea       rcx,[rsp+0F8]
       lea       r8,[rsp+0F0]
       lea       r9,[rsp+0E8]
       call      qword ptr [7FFC8DD05740]; System.Reflection.MetadataImport.GetPropertyProps(Int32, Void* ByRef, System.Reflection.PropertyAttributes ByRef, System.Reflection.ConstArray ByRef)
       mov       rax,[rsp+0E0]
       mov       [rsp+0D0],rax
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       r10,[rsp+70]
       mov       r9,[r10+30]
       mov       rcx,rax
       mov       rdx,[rsp+0D0]
       mov       r8d,[rsp+0D8]
       call      qword ptr [7FFC8DCA7A80]; System.Signature..ctor(Void*, Int32, System.RuntimeType)
       mov       rax,[rsp+70]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+70]
       jmp       near ptr M01_L17
M01_L38:
       cmp       r10d,5
       je        near ptr M01_L47
       cmp       r10d,8
       je        short M01_L41
       mov       rdx,rbx
       mov       r12d,[r14+10]
       mov       rcx,[r14+8]
       mov       ebx,[rcx+8]
       cmp       ebx,r12d
       jbe       short M01_L40
       cmp       r12d,ebx
       jae       near ptr M01_L93
       mov       eax,r12d
       shl       rax,4
       lea       rbx,[rcx+rax+10]
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+264]
       mov       [rbx+8],eax
       inc       dword ptr [r14+14]
       inc       r12d
       mov       [r14+10],r12d
       jmp       short M01_L41
M01_L39:
       mov       r9d,5
       jmp       near ptr M01_L08
M01_L40:
       mov       [rsp+0A0],rdx
       mov       r10d,[rsp+264]
       mov       [rsp+0A8],r10d
       mov       rcx,r14
       lea       rdx,[rsp+0A0]
       call      qword ptr [7FFC8DEC6700]; System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].PushWithResize(System.ValueTuple`2<Ferris.Json.Token,System.__Canon>)
M01_L41:
       mov       r10d,[rsp+264]
       mov       r12d,r10d
       mov       r9d,[rsp+260]
       cmp       r9d,ebp
       ja        near ptr M01_L58
       mov       edx,r9d
       lea       rdi,[rdi+rdx*2]
       sub       ebp,r9d
       jmp       near ptr M01_L07
M01_L42:
       test      r11d,r11d
       je        near ptr M01_L71
       cmp       r11d,1
       je        near ptr M01_L71
       jmp       near ptr M01_L12
M01_L43:
       mov       r9d,4
       jmp       near ptr M01_L08
M01_L44:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1E341C04E68
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFC8DEC27D8
       mov       [r13+18],rcx
       mov       rcx,1E341C04E70
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L45:
       test      rcx,rcx
       je        near ptr M01_L66
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L66
       mov       edx,1
       mov       r8d,1
       cmp       [rcx],ecx
       call      qword ptr [7FFC8D9F6E08]; System.RuntimeType.CreateInstanceDefaultCtor(Boolean, Boolean)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L67
       jmp       near ptr M01_L06
M01_L46:
       cmp       dword ptr [rsp+1E4],7
       jne       near ptr M01_L70
       test      eax,eax
       je        near ptr M01_L93
       movzx     r10d,word ptr [rbx]
       cmp       r10d,22
       jne       near ptr M01_L69
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+1A0],xmm0
       cmp       eax,1
       jb        near ptr M01_L58
       add       rbx,2
       sub       eax,1
       mov       [rsp+0C4],eax
       mov       edx,22
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FFC8DD356C8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       mov       [rsp+1B4],eax
       cmp       eax,[rsp+0C4]
       ja        near ptr M01_L58
       mov       [rsp+1A0],rbx
       mov       [rsp+1A8],eax
       lea       rcx,[rsp+1A0]
       call      qword ptr [7FFC8DB5C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       ebx,[rsp+1B4]
       add       ebx,2
       mov       [rsp+1D0],rax
       mov       [rsp+1D8],ebx
       jmp       near ptr M01_L10
M01_L47:
       mov       edx,[r14+10]
       dec       edx
       mov       r8d,edx
       mov       rcx,[r14+8]
       mov       ebx,[rcx+8]
       cmp       ebx,r8d
       jbe       short M01_L48
       cmp       r8d,ebx
       jae       near ptr M01_L93
       shl       r8,4
       lea       r8,[rcx+r8+10]
       cmp       ebx,edx
       jbe       near ptr M01_L57
       inc       dword ptr [r14+14]
       mov       [r14+10],edx
       xor       edx,edx
       mov       [r8],rdx
       mov       [r8+8],rdx
M01_L48:
       mov       r9d,[rsp+260]
       cmp       r9d,ebp
       ja        near ptr M01_L58
       mov       edx,r9d
       lea       rdi,[rdi+rdx*2]
       sub       ebp,r9d
M01_L49:
       mov       rcx,rsi
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rsi+8],rdi
       mov       [rsi+10],ebp
       mov       rax,rsi
       add       rsp,268
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L50:
       cmp       r12d,9
       jne       near ptr M01_L38
       lea       rdx,[rsp+228]
       mov       rcx,r14
       call      qword ptr [7FFC8DEC66B8]; System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Pop()
       mov       r12d,[rsp+230]
       mov       rbx,[rsp+228]
       lea       rdx,[rsp+218]
       mov       rcx,r14
       call      qword ptr [7FFC8DEC66B8]; System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Pop()
       mov       eax,[rsp+220]
       mov       r10,[rsp+218]
       cmp       dword ptr [rsp+230],9
       jne       near ptr M01_L41
       mov       r11,r10
       cmp       eax,6
       jne       near ptr M01_L41
       test      r11,r11
       mov       [rsp+25C],eax
       je        near ptr M01_L41
       mov       r8,r11
       mov       rcx,offset MT_System.String
       cmp       [r8],rcx
       jne       near ptr M01_L56
       lea       r8,[rsp+250]
       mov       rcx,r15
       mov       [rsp+80],r11
       mov       rdx,r11
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DB34630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L41
       mov       rcx,[rsp+250]
       mov       r8,[rsp+250]
       mov       r8,[r8]
       mov       r8,[r8+50]
       call      qword ptr [r8+10]
       mov       rdx,rax
       mov       [rsp+0B0],rdi
       mov       [rsp+0B8],ebp
       lea       r8,[rsp+0B0]
       lea       rcx,[rsp+238]
       call      qword ptr [7FFC8DE9FEA0]
       mov       edi,[rsp+25C]
       mov       rbp,[rsp+80]
       mov       [rsp+0A0],rbp
       mov       [rsp+0A8],edi
       mov       rcx,r14
       lea       rdx,[rsp+0A0]
       call      qword ptr [7FFC8DEC66E8]; System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Push(System.ValueTuple`2<Ferris.Json.Token,System.__Canon>)
       mov       [rsp+0A0],rbx
       mov       [rsp+0A8],r12d
       mov       rcx,r14
       lea       rdx,[rsp+0A0]
       call      qword ptr [7FFC8DEC66E8]; System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Push(System.ValueTuple`2<Ferris.Json.Token,System.__Canon>)
       mov       rcx,[rsp+238]
       mov       [rsp+0A0],rcx
       mov       dword ptr [rsp+0A8],7
       mov       rcx,r14
       lea       rdx,[rsp+0A0]
       call      qword ptr [7FFC8DEC66E8]; System.Collections.Generic.Stack`1[[System.ValueTuple`2[[Ferris.Json.Token, Ferris.Json],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].Push(System.ValueTuple`2<Ferris.Json.Token,System.__Canon>)
       mov       r12d,7
       mov       rdi,[rsp+240]
       mov       ebp,[rsp+248]
       jmp       near ptr M01_L07
M01_L51:
       mov       rdx,rax
       call      qword ptr [7FFC8DAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L52:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFC8DFD5368]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFC8DAAF708]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L53:
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFC8DFDD980]
       mov       rdx,rax
       mov       rcx,r13
       xor       r8d,r8d
       call      qword ptr [7FFC8DD75998]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,offset MT_System.Reflection.TargetParameterCountException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC8DFD5188]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC8DD75908]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L55:
       mov       rcx,r9
       mov       rdx,r10
       call      qword ptr [7FFC8DAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L56:
       mov       rdx,r11
       call      qword ptr [7FFC8DAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L57:
       mov       rcx,r14
       call      qword ptr [7FFC8DEC6760]
       int       3
M01_L58:
       call      qword ptr [7FFC8DC4E9D0]
       int       3
M01_L59:
       mov       rdx,1E341C01E40
       mov       r15,[rdx]
       jmp       near ptr M01_L02
M01_L60:
       lea       rdx,[rsp+1E8]
       mov       r8d,[rsp+1F8]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFC8DC7FA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+1F8]
       mov       [rsp+1FC],ecx
       mov       r15,[rsp+1E8]
       jmp       near ptr M01_L02
M01_L61:
       mov       rcx,rbx
       mov       edx,14
       mov       rax,[rbx]
       mov       rax,[rax+90]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L62:
       cmp       r10d,2C
       jne       short M01_L63
       mov       edx,8
       mov       r9d,edx
       jmp       near ptr M01_L08
M01_L63:
       cmp       r12d,9
       jne       short M01_L64
       mov       edx,7
       mov       r9d,edx
       jmp       near ptr M01_L08
M01_L64:
       xor       edx,edx
       mov       r9d,edx
       jmp       near ptr M01_L08
M01_L65:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M01_L45
M01_L66:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFC8DFD4E58]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFC8D954000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rdi
       call      qword ptr [7FFC8DAAF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       [rsp+208],rdi
       mov       [rsp+210],ebp
       vmovdqu   xmm0,xmmword ptr [rsp+200]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,[rsp+210]
       mov       [rsi+10],rax
       mov       rax,rsi
       add       rsp,268
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L68:
       mov       edx,2
       mov       r9d,edx
       jmp       near ptr M01_L08
M01_L69:
       mov       [rsp+0B0],rbx
       mov       [rsp+0B8],eax
       lea       rdx,[rsp+0B0]
       lea       rcx,[rsp+1D0]
       call      qword ptr [7FFC8DE9FF18]
       jmp       near ptr M01_L10
M01_L70:
       mov       rcx,1E300200008
       mov       [rsp+1D0],rcx
       xor       ecx,ecx
       mov       [rsp+1D8],ecx
       jmp       near ptr M01_L10
M01_L71:
       mov       eax,r11d
       xor       ebx,ebx
       mov       ecx,eax
       mov       r10d,1
       mov       eax,r10d
       mov       r8d,ecx
       jmp       near ptr M01_L13
M01_L72:
       mov       rcx,rax
       mov       [rsp+70],rax
       mov       rdx,[rax]
       mov       rdx,[rdx+50]
       call      qword ptr [rdx+10]
       mov       rcx,rax
       mov       rdx,rcx
       mov       rax,[rsp+70]
       jmp       near ptr M01_L18
M01_L73:
       mov       [rsp+70],rax
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+98]
       call      qword ptr [rdx+20]
       mov       rcx,1E3002021B8
       cmp       rax,rcx
       mov       rax,[rsp+70]
       je        near ptr M01_L19
       mov       r8,[rsp+68]
       mov       r10,[rsp+88]
       mov       rcx,r10
       mov       r9,offset MT_System.String
       cmp       [rcx],r9
       jne       near ptr M01_L55
       jmp       short M01_L77
M01_L74:
       xor       eax,eax
       xor       ecx,ecx
       mov       rax,rcx
       jmp       near ptr M01_L20
M01_L75:
       xor       ecx,ecx
       jmp       near ptr M01_L23
M01_L76:
       mov       rcx,rax
       mov       rdx,r13
       mov       r8,[rsp+88]
       xor       r9d,r9d
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L77:
       mov       r9,1E300204FC0
       cmp       r8,r9
       jne       short M01_L78
       mov       [rsp+70],rax
       lea       r9,[rsp+108]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8D9FDC98]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+108]
       mov       [rax+8],r8d
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L78:
       mov       r9,1E300208778
       cmp       r8,r9
       jne       short M01_L79
       mov       [rsp+70],rax
       lea       r9,[rsp+110]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA548B8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+110]
       mov       [rax+8],r8d
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L79:
       mov       r9,1E3002087A0
       cmp       r8,r9
       jne       short M01_L80
       mov       [rsp+70],rax
       lea       r9,[rsp+11C]
       mov       edx,0E7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA5C840]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       vmovss    xmm0,dword ptr [rsp+11C]
       vmovss    dword ptr [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L80:
       mov       r9,1E300205718
       cmp       r8,r9
       jne       short M01_L81
       mov       [rsp+70],rax
       lea       r9,[rsp+120]
       mov       edx,0E7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA8C648]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       vmovsd    xmm0,qword ptr [rsp+120]
       vmovsd    qword ptr [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L81:
       mov       rdx,1E300203C30
       cmp       r8,rdx
       jne       short M01_L82
       mov       [rsp+70],rax
       lea       rdx,[rcx+0C]
       mov       ecx,[rcx+8]
       mov       [rsp+0B0],rdx
       mov       [rsp+0B8],ecx
       lea       rcx,[rsp+0B0]
       lea       rdx,[rsp+128]
       call      qword ptr [7FFC8D9FCA98]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+128]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L82:
       mov       r9,1E3002087C8
       cmp       r8,r9
       jne       short M01_L83
       mov       [rsp+70],rax
       lea       r9,[rsp+130]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA3D2D8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+130]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L83:
       mov       r9,1E3002087F0
       cmp       r8,r9
       jne       short M01_L84
       mov       [rsp+70],rax
       lea       r9,[rsp+138]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA3C2B8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+138]
       mov       [rax+8],r8b
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L84:
       mov       rdx,1E300208818
       cmp       r8,rdx
       jne       short M01_L85
       mov       [rsp+70],rax
       lea       rdx,[rsp+140]
       call      qword ptr [7FFC8DA35B60]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+140]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L85:
       mov       r9,1E300208840
       cmp       r8,r9
       jne       short M01_L86
       mov       [rsp+70],rax
       lea       r9,[rsp+148]
       mov       edx,6F
       xor       r8d,r8d
       call      qword ptr [7FFC8DBD4558]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       vmovups   xmm0,[rsp+148]
       vmovups   [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L86:
       mov       r9,1E300205F58
       cmp       r8,r9
       jne       short M01_L87
       mov       [rsp+70],rax
       lea       r9,[rsp+158]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA559C8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+158]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L87:
       mov       r9,1E300208868
       cmp       r8,r9
       jne       short M01_L88
       mov       [rsp+70],rax
       lea       r9,[rsp+160]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA56AF0]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+160]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L88:
       mov       r9,1E300208890
       cmp       r8,r9
       jne       short M01_L89
       mov       [rsp+70],rax
       lea       r9,[rsp+168]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DC2D668]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Int128
       call      CORINFO_HELP_NEWSFAST
       vmovups   xmm0,[rsp+168]
       vmovups   [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L89:
       mov       r9,1E3002088B8
       cmp       r8,r9
       jne       short M01_L90
       mov       [rsp+70],rax
       lea       r9,[rsp+178]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DE543D8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.UInt128
       call      CORINFO_HELP_NEWSFAST
       vmovups   xmm0,[rsp+178]
       vmovups   [rax+8],xmm0
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L90:
       mov       r9,1E3002088E0
       cmp       r8,r9
       jne       short M01_L91
       mov       [rsp+70],rax
       lea       r9,[rsp+188]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA3E580]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+188]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L91:
       mov       r9,1E300208660
       cmp       r8,r9
       jne       short M01_L92
       mov       [rsp+70],rax
       lea       r9,[rsp+190]
       mov       edx,7
       xor       r8d,r8d
       call      qword ptr [7FFC8DA3F6A8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       r8d,[rsp+190]
       mov       [rax+8],r8w
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L92:
       mov       rdx,1E300208908
       cmp       r8,rdx
       mov       [rsp+70],rax
       jne       near ptr M01_L34
       lea       rdx,[rsp+198]
       call      qword ptr [7FFC8DD7F0D8]
       test      eax,eax
       je        near ptr M01_L34
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rsp+198]
       mov       [rax+8],r8
       mov       r8,rax
       mov       rcx,[rsp+70]
       mov       rdx,r13
       xor       r9d,r9d
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L34
M01_L93:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 5544
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],2
       jl        short M02_L02
       mov       rax,[rax+198]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L02
       mov       rdx,[rax]
       add       rdx,10
M02_L00:
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L01
       mov       rax,1E341C00438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,1E341C00418
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L03
M02_L01:
       add       rsp,28
       ret
M02_L02:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       short M02_L00
M02_L03:
       add       rsp,28
       jmp       qword ptr [7FFC8DBF4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 124
```
```assembly
; System.Convert.ChangeType(System.Object, System.Type, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        short M03_L02
       test      rbx,rbx
       je        short M03_L03
       mov       rdx,rbx
       mov       rcx,offset MT_System.IConvertible
       call      qword ptr [7FFC8DAA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M03_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       rax,rsi
       jne       short M03_L05
M03_L00:
       mov       rax,rbx
M03_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       ecx,1D4F
       mov       rdx,7FFC8D954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC8DC766E8]
       int       3
M03_L03:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M03_L04
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFC8DFDC3F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFC8DEC7B10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L05:
       mov       rcx,offset MT_System.InvalidCastException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFC8DFDC480]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFC8DEC7B10]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M03_L06:
       mov       rcx,1E300203C30
       cmp       rsi,rcx
       jne       short M03_L07
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605F0
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L07:
       mov       rcx,1E300208818
       cmp       rsi,rcx
       jne       short M03_L08
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605E8
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L08:
       mov       rcx,1E3002087F0
       cmp       rsi,rcx
       jne       short M03_L09
       mov       rcx,offset MT_System.SByte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605E0
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L09:
       mov       rcx,1E3002087C8
       cmp       rsi,rcx
       jne       short M03_L10
       mov       rcx,offset MT_System.Byte
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605D8
       call      qword ptr [r11]
       mov       [rsi+8],al
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L10:
       mov       rcx,1E3002088E0
       cmp       rsi,rcx
       jne       short M03_L11
       mov       rcx,offset MT_System.Int16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605D0
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L11:
       mov       rcx,1E300208660
       cmp       rsi,rcx
       jne       short M03_L12
       mov       rcx,offset MT_System.UInt16
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605C8
       call      qword ptr [r11]
       mov       [rsi+8],ax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L12:
       mov       rcx,1E300204FC0
       cmp       rsi,rcx
       jne       short M03_L13
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605C0
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L13:
       mov       rcx,1E300208778
       cmp       rsi,rcx
       jne       short M03_L14
       mov       rcx,offset MT_System.UInt32
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605B8
       call      qword ptr [r11]
       mov       [rsi+8],eax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,1E300205F58
       cmp       rsi,rcx
       jne       short M03_L15
       mov       rcx,offset MT_System.Int64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605B0
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L15:
       mov       rcx,1E300208868
       cmp       rsi,rcx
       jne       short M03_L16
       mov       rcx,offset MT_System.UInt64
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605A8
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L16:
       mov       rcx,1E3002087A0
       cmp       rsi,rcx
       jne       short M03_L17
       mov       rcx,offset MT_System.Single
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D9605A0
       call      qword ptr [r11]
       vmovss    dword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L17:
       mov       rcx,1E300205718
       cmp       rsi,rcx
       jne       short M03_L18
       mov       rcx,offset MT_System.Double
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D960598
       call      qword ptr [r11]
       vmovsd    qword ptr [rsi+8],xmm0
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L18:
       mov       rcx,1E300208840
       cmp       rsi,rcx
       jne       short M03_L19
       mov       rcx,offset MT_System.Decimal
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rdx,[rsi+8]
       mov       rcx,rbp
       mov       r8,rdi
       mov       r11,7FFC8D960590
       call      qword ptr [r11]
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L19:
       mov       rcx,1E300208908
       cmp       rsi,rcx
       jne       short M03_L20
       mov       rcx,offset MT_System.DateTime
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D960588
       call      qword ptr [r11]
       mov       [rsi+8],rax
       mov       rax,rsi
       jmp       near ptr M03_L01
M03_L20:
       mov       rcx,1E300200020
       cmp       rsi,rcx
       jne       short M03_L21
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r11,7FFC8D960580
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M03_L21:
       mov       rcx,1E3002021B8
       cmp       rsi,rcx
       je        near ptr M03_L00
       mov       rcx,rbp
       mov       r8,rdi
       mov       rdx,rsi
       mov       r11,7FFC8D960578
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 1216
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M04_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      r8,r8
       je        short M04_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L03
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       jne       short M04_L00
M04_L03:
       jmp       qword ptr [7FFC8DAA43A8]
; Total bytes of code 69
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M05_L04
       mov       eax,edx
       shr       eax,3
M05_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M05_L00
       test      dl,4
       jne       short M05_L03
M05_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M05_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M05_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M05_L01
M05_L04:
       cmp       edx,4
       jae       short M05_L03
       mov       eax,80
       test      dl,1
       je        short M05_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M05_L05:
       test      dl,2
       mov       edx,eax
       je        short M05_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M05_L02
; Total bytes of code 264
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.DeserializationBenchmark.NewtonsoftValueMapping()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,16E49804188
       mov       rcx,[rcx]
       mov       rdx,16E00208750
       xor       r8d,r8d
       call      qword ptr [7FFC8DED4510]; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       mov       r8,rax
       test      r8,r8
       je        short M00_L00
       mov       rcx,offset MT_Ferris.Json.Test.TestObjects.StringPropertyObj
       cmp       [r8],rcx
       je        short M00_L00
       mov       rdx,rax
       call      qword ptr [7FFC8DAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M00_L00:
       mov       esi,[rbx+8]
       mov       rcx,[r8+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,61BF5A5F
       mov       r9d,0EC840397
       call      qword ptr [7FFC8E00CF30]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 122
```
```assembly
; Newtonsoft.Json.JsonConvert.DeserializeObject(System.String, System.Type, Newtonsoft.Json.JsonSerializerSettings)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M01_L03
       mov       rcx,16E49804E68
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L04
       xor       r14d,r14d
M01_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFC8DED6A18]; Newtonsoft.Json.JsonSerializer..ctor()
       test      r14,r14
       jne       near ptr M01_L05
       test      rsi,rsi
       jne       near ptr M01_L06
M01_L01:
       cmp       byte ptr [r15+0D0],0
       jne       short M01_L02
       mov       byte ptr [r15+0D0],1
       mov       byte ptr [r15+0D1],1
M01_L02:
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextReader
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsi+2C],ecx
       mov       dword ptr [rsi+30],3
       mov       dword ptr [rsi+34],1
       mov       [rsi+38],ecx
       mov       byte ptr [rsi+60],1
       mov       dword ptr [rsi+64],40
       mov       byte ptr [rsi+3F],1
       lea       rcx,[rsi+68]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+94],1
       mov       byte ptr [rsi+98],1
       mov       [rbp-30],rsi
       mov       rcx,r15
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFC8DEE0F18]; Newtonsoft.Json.JsonSerializer.DeserializeInternal(Newtonsoft.Json.JsonReader, System.Type)
       mov       [rbp-38],rax
       mov       rcx,rsp
       call      M01_L07
       nop
       mov       rax,[rbp-38]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC8DEAA968
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC8DC76640]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L00
M01_L05:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FFC8DED6A90]
       test      rsi,rsi
       je        near ptr M01_L01
M01_L06:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFC8DED6A90]
       jmp       near ptr M01_L01
M01_L07:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rsi,[rbp-30]
       cmp       dword ptr [rsi+2C],7
       je        near ptr M01_L14
       mov       dword ptr [rsi+2C],7
       xor       ecx,ecx
       mov       [rsi+28],ecx
       mov       [rsi+8],rcx
       mov       rdx,[rsi+70]
       test      rdx,rdx
       je        short M01_L09
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M01_L08
       mov       r11,7FFC8D970BD0
       call      qword ptr [r11]
M01_L08:
       xor       ecx,ecx
       mov       [rsi+70],rcx
M01_L09:
       cmp       byte ptr [rsi+3F],0
       je        short M01_L11
       mov       rcx,[rsi+68]
       test      rcx,rcx
       je        short M01_L11
       mov       rax,offset MT_System.IO.StringReader
       cmp       [rcx],rax
       jne       short M01_L10
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],eax
       jmp       short M01_L11
M01_L10:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L11:
       lea       r14,[rsi+0A0]
       mov       rcx,[rsi+78]
       cmp       qword ptr [r14],0
       je        short M01_L13
       mov       rdx,[r14]
       test      rcx,rcx
       je        short M01_L12
       mov       r11,7FFC8D970BD8
       call      qword ptr [r11]
M01_L12:
       xor       eax,eax
       mov       [r14],rax
M01_L13:
       xor       ecx,ecx
       mov       [r14+8],ecx
M01_L14:
       mov       rcx,rsi
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 629
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M02_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M02_L02
M02_L01:
       mov       rax,rdx
       ret
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L01
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L01
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L01
       test      rax,rax
       jne       short M02_L00
M02_L03:
       lea       rax,[7FFCEAE1B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 264
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.DeserializationBenchmark.TextJsonValueMapping()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rax,19351404188
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L05
       call      qword ptr [7FFC8DEC4F18]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdi,rax
       cmp       byte ptr [rdi+9E],0
       je        near ptr M00_L06
M00_L00:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L04
       mov       rcx,[rbp+0B8]
       mov       r9,19300208770
       cmp       rcx,r9
       jne       short M00_L04
M00_L01:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L03
M00_L02:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+30],rdx
       mov       [rsp+38],ecx
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.StringPropertyObj>)
       call      qword ptr [7FFC8DEC6B08]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       esi,[rbx+8]
       mov       rcx,[rax+8]
       mov       edx,[rcx+8]
       add       edx,edx
       add       rcx,0C
       mov       r8d,68252FEF
       mov       r9d,0CEDE32F0
       call      qword ptr [7FFC8DF65140]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       add       eax,esi
       mov       [rbx+8],eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.StringPropertyObj, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       short M00_L07
       jmp       short M00_L02
M00_L04:
       mov       byte ptr [rsp+40],1
       mov       byte ptr [rsp+41],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rdi
       movzx     r9d,word ptr [rsp+40]
       mov       rdx,19300208770
       mov       r8d,1
       call      qword ptr [7FFC8DEC4DF8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L05:
       mov       ecx,389E
       mov       rdx,7FFC8DE9AA18
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC8DEC6B68]
       int       3
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FFC8DEC5548]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFC8DAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 337
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,19351404F28
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,19351404F28
       xor       edx,edx
       jmp       qword ptr [7FFC8DEC55F0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,228
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+200],xmm4
       vmovdqa   xmmword ptr [rbp+rax+210],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+1F0],rax
       mov       [rbp],rsp
       mov       rax,9849D09CE274
       mov       [rbp+8],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+18],rcx
       cmp       edi,55
       jg        near ptr M02_L08
       test      [rsp],esp
       sub       rsp,100
       lea       rax,[rsp+30]
       mov       r8d,100
M02_L01:
       mov       [rbp+10],rax
       mov       [rbp+54],r8d
       mov       [rbp+40],rsi
       mov       [rbp+48],edi
       mov       rcx,[rbp+10]
       mov       [rbp+30],rcx
       mov       ecx,[rbp+54]
       mov       [rbp+38],ecx
       lea       rcx,[rbp+40]
       lea       rdx,[rbp+30]
       call      qword ptr [7FFC8DECD080]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp+54]
       ja        short M02_L04
       mov       rdx,[rbp+10]
       mov       [rbp+10],rdx
       mov       [rbp+54],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+94]
       movzx     r8d,byte ptr [rcx+92]
       cmp       r8d,2
       jg        short M02_L03
       mov       ecx,[rcx+88]
       test      ecx,ecx
       jl        short M02_L02
       jmp       short M02_L05
M02_L02:
       mov       ecx,347F
       mov       rdx,7FFC8DE9AA18
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC8DEC6BC8]
       int       3
M02_L03:
       mov       ecx,347F
       mov       rdx,7FFC8DE9AA18
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC8DEC6C10]
       int       3
M02_L04:
       call      qword ptr [7FFC8DC3E9D0]
       int       3
M02_L05:
       movzx     r8d,r8b
       movzx     r9d,r9b
       xor       r10d,r10d
       mov       [rbp+1C0],r10
       mov       [rbp+1C8],r10
       mov       byte ptr [rbp+1D0],0
       mov       byte ptr [rbp+1D1],0
       mov       byte ptr [rbp+1D2],0
       mov       byte ptr [rbp+1D3],0
       mov       byte ptr [rbp+1D4],0
       mov       byte ptr [rbp+1D5],0
       mov       [rbp+1D8],ecx
       mov       [rbp+1DC],r8b
       mov       [rbp+1DD],r9b
       mov       byte ptr [rbp+1DE],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+1E0],xmm0
       vmovdqu   xmmword ptr [rbp+1E8],xmm0
       mov       [rbp+20],rdx
       mov       [rbp+28],eax
       lea       rdx,[rbp+20]
       lea       rcx,[rbp+100]
       lea       r9,[rbp+1C0]
       mov       r8d,1
       call      qword ptr [7FFC8E035800]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+60],ymm0
       vmovdqu   ymmword ptr [rbp+80],ymm0
       vmovdqu   ymmword ptr [rbp+0A0],ymm0
       vmovdqu   ymmword ptr [rbp+0C0],ymm0
       vmovdqu   ymmword ptr [rbp+0E0],ymm0
       lea       rcx,[rbp+60]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFC8E0368B0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       lea       rcx,[rbp+60]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+150]
       mov       r9,[rbx+0B0]
       lea       r8,[rbp+58]
       lea       rdx,[rbp+100]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF65938]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rdi,[rbp+58]
       xor       edx,edx
       mov       [rbp+58],rdx
       cmp       qword ptr [rbp+18],0
       je        short M02_L06
       mov       edx,[rbp+54]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DB55278]
       mov       rcx,7FFC8D9E5120
       mov       edx,23
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19351401F18
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFC8E09C770]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M02_L06:
       mov       rax,rdi
       mov       rcx,9849D09CE274
       cmp       [rbp+8],rcx
       je        short M02_L07
       call      CORINFO_HELP_FAIL_FAST
M02_L07:
       nop
       lea       rsp,[rbp+1F8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L08:
       cmp       edi,15555555
       jbe       short M02_L09
       mov       [rbp+40],rsi
       mov       [rbp+48],edi
       lea       rcx,[rbp+40]
       call      qword ptr [7FFC8DECD068]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M02_L10
M02_L09:
       mov       rcx,7FFC8D9E5120
       mov       edx,23
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19351401F18
       mov       rcx,[rcx]
       lea       edx,[rdi+rdi*2]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8E09C768]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+18],rax
M02_L10:
       test      rax,rax
       jne       short M02_L11
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M02_L12
M02_L11:
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       mov       ecx,eax
       mov       rax,r8
       mov       r8d,ecx
M02_L12:
       jmp       near ptr M02_L01
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+30]
       cmp       qword ptr [rbp+18],0
       je        short M02_L13
       mov       edx,[rbp+54]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DB55278]
       mov       rcx,7FFC8D9E5120
       mov       edx,23
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,19351401F18
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFC8E09C770]; Precode of System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M02_L13:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 905
```
```assembly
; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       cmp       edx,8
       jb        near ptr M03_L04
       mov       eax,edx
       shr       eax,3
M03_L00:
       add       r8d,[rcx]
       mov       r10d,[rcx+4]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       add       r10d,r8d
       mov       r8d,r9d
       xor       r8d,r10d
       rol       r10d,14
       add       r10d,r8d
       rol       r8d,9
       xor       r8d,r10d
       rol       r10d,1B
       add       r10d,r8d
       rol       r8d,13
       mov       r9d,r8d
       add       rcx,8
       dec       eax
       mov       r8d,r10d
       jne       short M03_L00
       test      dl,4
       jne       short M03_L03
M03_L01:
       mov       eax,edx
       and       rax,7
       mov       eax,[rcx+rax-4]
       shr       eax,8
       or        eax,80000000
       not       edx
       shl       edx,3
       shrx      edx,eax,edx
M03_L02:
       add       edx,r8d
       mov       eax,r9d
       xor       eax,edx
       rol       edx,14
       add       edx,eax
       rol       eax,9
       xor       eax,edx
       rol       edx,1B
       add       edx,eax
       rol       eax,13
       xor       eax,edx
       mov       ecx,edx
       rol       ecx,14
       add       ecx,eax
       rol       eax,9
       xor       eax,ecx
       rol       ecx,1B
       add       ecx,eax
       rol       eax,13
       xor       eax,ecx
       ret
M03_L03:
       add       r8d,[rcx]
       xor       r9d,r8d
       rol       r8d,14
       add       r8d,r9d
       rol       r9d,9
       xor       r9d,r8d
       rol       r8d,1B
       add       r8d,r9d
       rol       r9d,13
       jmp       short M03_L01
M03_L04:
       cmp       edx,4
       jae       short M03_L03
       mov       eax,80
       test      dl,1
       je        short M03_L05
       mov       eax,edx
       and       rax,2
       movzx     eax,byte ptr [rcx+rax]
       or        eax,8000
M03_L05:
       test      dl,2
       mov       edx,eax
       je        short M03_L02
       shl       edx,10
       movzx     eax,word ptr [rcx]
       or        edx,eax
       jmp       near ptr M03_L02
; Total bytes of code 264
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-18],xmm4
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9
       xor       ecx,ecx
       mov       [rbp-8],rcx
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEC5500]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M04_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEC4DB0]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF64360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M04_L01
       cmp       qword ptr [rbp-8],0
       je        short M04_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC8DEC61D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M04_L01
M04_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M04_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC8DEC5560]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M04_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M04_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC8DD64720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M04_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC8DEC4FC0]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC8DEC7AB0]
M04_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M05_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M05_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M05_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC8DEC4390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M05_L05
       call      qword ptr [7FFC8DECC318]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC8DAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M05_L03
       jmp       near ptr M05_L09
M05_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L03:
       call      qword ptr [7FFC8DECC528]
       test      eax,eax
       je        near ptr M05_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC8DF64450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC8DF64450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC8DF64480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC8DECC3F0]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M05_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF64318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF64318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M05_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF64318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DEC5548]
       jmp       short M05_L09
M05_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC8DF64390]
       jmp       short M05_L09
M05_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M05_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC8DAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M05_L07
M05_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M05_L08
M05_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M05_L08:
       cmp       dword ptr [rbp-34],0
       je        short M05_L09
       call      qword ptr [7FFC8DEC74C8]
M05_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M06_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M06_L02
M06_L01:
       mov       rax,rdx
       ret
M06_L02:
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       je        short M06_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L01
       test      rax,rax
       jne       short M06_L00
M06_L03:
       lea       rax,[7FFCEAE1B908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

