## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ObjectMapperBenchmarks.FerrisSingleProperty()
       sub       rsp,28
       mov       rcx,[rcx+8]
       call      qword ptr [7FFC91935EF0]; Ferris.Json.JsonTransformer.ToJson(System.Object)
       nop
       add       rsp,28
       ret
; Total bytes of code 20
```
```assembly
; Ferris.Json.JsonTransformer.ToJson(System.Object)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,128
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+120],xmm4
       vmovdqa   xmmword ptr [rsp+rax+130],xmm4
       vmovdqa   xmmword ptr [rsp+rax+140],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+120],rax
       mov       rbx,rcx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+0E8]
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFC914766D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+0F8],0
       je        near ptr M01_L27
       cmp       dword ptr [rsp+0F8],1
       jne       near ptr M01_L28
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rsp+0F0]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       test      edx,edx
       je        near ptr M01_L29
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       xor       ebp,ebp
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L22
M01_L03:
       mov       ecx,ebp
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r14],rcx
       jne       near ptr M01_L30
       mov       rcx,r14
       cmp       qword ptr [rcx+18],0
       je        short M01_L05
       mov       rcx,[r14+18]
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L65
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFC91713188]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r15,rax
       jmp       short M01_L06
M01_L05:
       xor       ecx,ecx
       jmp       short M01_L04
M01_L06:
       xor       ecx,ecx
       mov       [rsp+100],rcx
       mov       rcx,24C8F001DF8
       mov       r13,[rcx]
       mov       rcx,r13
       mov       edx,100
       call      qword ptr [7FFC91709EF0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+108],rax
       test      rax,rax
       je        near ptr M01_L31
       lea       r12,[rax+10]
       mov       eax,[rax+8]
M01_L07:
       mov       [rsp+118],r12
       mov       [rsp+120],eax
       xor       r8d,r8d
       mov       [rsp+110],r8d
       mov       byte ptr [rsp+114],0
       mov       r8d,[rsp+110]
       cmp       r8d,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,r8d
       cmp       edx,1
       jb        near ptr M01_L32
       mov       r8,24C80208734
       movzx     edx,word ptr [r8]
       mov       [rcx],dx
       mov       r8d,[rsp+110]
       inc       r8d
       mov       [rsp+110],r8d
M01_L08:
       mov       r8,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r14],r8
       jne       near ptr M01_L34
       mov       r12,[r14+8]
       test      r12,r12
       je        near ptr M01_L33
M01_L09:
       cmp       byte ptr [rsp+114],0
       jne       near ptr M01_L35
M01_L10:
       test      r12,r12
       je        near ptr M01_L35
       mov       r8d,[rsp+110]
       cmp       r8d,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,r8d
       cmp       [r12+8],edx
       ja        near ptr M01_L35
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFC915D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rsp+110]
       add       edx,[r12+8]
       mov       [rsp+110],edx
M01_L11:
       mov       edx,[rsp+110]
       cmp       edx,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+120]
       sub       eax,edx
       cmp       eax,3
       jb        near ptr M01_L36
       mov       rdx,24C8020874C
       mov       eax,[rdx]
       mov       r8d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r8d
       mov       edx,[rsp+110]
       add       edx,3
       mov       [rsp+110],edx
       mov       [rsp+0C0],r15
       cmp       byte ptr [rsp+114],0
       jne       near ptr M01_L37
M01_L12:
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC91524348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L24
       xor       r8d,r8d
       mov       [rsp+0B8],r8
       lea       r8,[rsp+0C0]
       cmp       qword ptr [rsp+0B8],0
       jne       short M01_L13
       mov       r8,[r8]
       mov       [rsp+0B8],r8
       lea       r8,[rsp+0B8]
       cmp       qword ptr [rsp+0B8],0
       je        near ptr M01_L38
M01_L13:
       mov       rcx,[r8]
       mov       r8,offset MT_System.String
       cmp       [rcx],r8
       jne       near ptr M01_L39
M01_L14:
       mov       r15,rcx
M01_L15:
       test      r15,r15
       je        short M01_L16
       mov       r8d,[rsp+110]
       cmp       r8d,[rsp+120]
       ja        near ptr M01_L66
       mov       rcx,[rsp+118]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,r8d
       cmp       [r15+8],edx
       ja        near ptr M01_L40
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8,r8
       call      qword ptr [7FFC915D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+110]
       add       ecx,[r15+8]
       mov       [rsp+110],ecx
M01_L16:
       xor       ecx,ecx
       mov       [rsp+0B8],rcx
       mov       ecx,[rsp+110]
       cmp       ecx,[rsp+120]
       ja        near ptr M01_L66
       mov       rax,[rsp+118]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+120]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L46
       mov       rcx,24C80208734
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+110]
       inc       ecx
       mov       [rsp+110],ecx
M01_L17:
       mov       ecx,[rsp+110]
       cmp       ecx,[rsp+120]
       ja        near ptr M01_L66
       mov       rax,[rsp+118]
       mov       [rsp+60],rax
       mov       [rsp+68],ecx
       lea       rcx,[rsp+60]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r15,rax
       mov       r12,[rsp+108]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+100],ymm0
       vmovdqu   xmmword ptr [rsp+118],xmm0
       test      r12,r12
       je        near ptr M01_L20
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFC91465120
       mov       edx,0A
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L41
M01_L18:
       xor       eax,eax
       mov       dword ptr [rsp+0A8],1
       mov       edx,[rcx+8]
       cmp       edx,r14d
       jbe       short M01_L19
       mov       dword ptr [rsp+0AC],1
       mov       edx,10
       shlx      edx,edx,r14d
       cmp       [r12+8],edx
       jne       near ptr M01_L67
       mov       edx,r14d
       shl       rdx,4
       lea       r10,[rcx+rdx+10]
       mov       [rsp+48],r10
       mov       r9,[r10]
       mov       [rsp+40],r9
       mov       rcx,r10
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+48]
       mov       [rdx+8],ecx
       mov       rax,[rsp+40]
       test      rax,rax
       mov       [rsp+40],rax
       mov       eax,[rsp+0AC]
       jne       near ptr M01_L42
M01_L19:
       mov       rcx,24C8F0005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M01_L59
M01_L20:
       mov       rdx,r15
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L64
       lea       r8d,[rax+1]
       mov       [rdi+10],r8d
       cmp       eax,[rcx+8]
       jae       near ptr M01_L68
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L21:
       inc       ebp
       cmp       [rsi+8],ebp
       jg        near ptr M01_L03
M01_L22:
       mov       rdx,rdi
       mov       rcx,24C80200C60
       call      qword ptr [7FFC91526DC0]; System.String.Join(System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L25
       mov       r13d,[rbx+8]
       test      r13d,r13d
       je        near ptr M01_L25
       mov       ecx,r13d
       add       rcx,2
       cmp       rcx,7FFFFFFF
       jg        near ptr M01_L26
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       rcx,24C8020876C
       movzx     edx,word ptr [rcx]
       mov       [r8],dx
       lea       rcx,[r14+0E]
       lea       rdx,[rbx+0C]
       mov       r8d,r13d
       add       r8,r8
       call      qword ptr [7FFC915D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       inc       r13d
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       mov       rdx,24C80208784
       movzx     r8d,word ptr [rdx]
       mov       [rax],r8w
       mov       rax,r14
M01_L23:
       add       rsp,128
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC91524348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L45
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFC915243C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       r8,[rsp+100]
       mov       r11,7FFC913E0548
       xor       edx,edx
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M01_L15
M01_L25:
       mov       rcx,24C80208760
       mov       rdx,24C80208778
       call      qword ptr [7FFC91526B08]; System.String.Concat(System.String, System.String)
       jmp       near ptr M01_L23
M01_L26:
       call      qword ptr [7FFC916CEF40]
       int       3
M01_L27:
       mov       rdx,24C8F001E40
       mov       rsi,[rdx]
       jmp       near ptr M01_L01
M01_L28:
       lea       rdx,[rsp+0E8]
       mov       r8d,[rsp+0F8]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFC916FFA68]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rsp+0F8]
       mov       [rsp+0FC],ecx
       mov       rsi,[rsp+0E8]
       jmp       near ptr M01_L01
M01_L29:
       mov       rcx,24C8F001E10
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L30:
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M01_L06
M01_L31:
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L32:
       lea       rcx,[rsp+100]
       mov       rdx,24C80208728
       call      qword ptr [7FFC916558F0]
       jmp       near ptr M01_L08
M01_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0D8],xmm0
       mov       rdx,[r14+48]
       lea       rcx,[rsp+0D8]
       call      qword ptr [7FFC91726AC0]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+0D8]
       vmovups   [rsp+0C8],xmm0
       lea       rcx,[rsp+0C8]
       call      qword ptr [7FFC91726B38]; System.MdUtf8String.ToString()
       mov       r12,rax
       lea       rcx,[r14+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L34:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r12,rax
       cmp       byte ptr [rsp+114],0
       je        near ptr M01_L10
M01_L35:
       lea       rcx,[rsp+100]
       mov       rdx,r12
       call      qword ptr [7FFC91655848]
       jmp       near ptr M01_L11
M01_L36:
       lea       rcx,[rsp+100]
       mov       rdx,24C80208740
       call      qword ptr [7FFC916558F0]
       mov       [rsp+0C0],r15
       cmp       byte ptr [rsp+114],0
       je        near ptr M01_L12
M01_L37:
       lea       rcx,[rsp+100]
       mov       r8,[rsp+0C0]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendCustomFormatter[[System.Object, System.Private.CoreLib]](System.Object, System.String)
       xor       r9d,r9d
       call      qword ptr [7FFC91A7E4D8]
       jmp       near ptr M01_L16
M01_L38:
       xor       r15d,r15d
       jmp       near ptr M01_L15
M01_L39:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L14
M01_L40:
       lea       rcx,[rsp+100]
       mov       rdx,r15
       call      qword ptr [7FFC916558F0]
       jmp       near ptr M01_L16
M01_L41:
       mov       rcx,r13
       call      qword ptr [7FFC916FD860]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L18
M01_L42:
       mov       rcx,[r13+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L68
       mov       edx,r14d
       mov       r10,[rcx+rdx*8+10]
       test      r10,r10
       mov       [rsp+0AC],eax
       jne       short M01_L43
       mov       rcx,r13
       mov       edx,r14d
       call      qword ptr [7FFC916FD7E8]
       mov       r10,rax
M01_L43:
       mov       r10,[r10+8]
       mov       [rsp+38],r10
       mov       rcx,7FFC91465120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFC91465C38],0
       je        near ptr M01_L47
       call      qword ptr [7FFC9152DC98]
       mov       edx,eax
       mov       [rsp+90],edx
       jmp       near ptr M01_L50
M01_L44:
       lea       rcx,[rsp+100]
       call      qword ptr [7FFC91655938]
M01_L45:
       mov       rdx,[rsp+0C0]
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFC915243C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,rax
       mov       edx,[rsp+110]
       cmp       edx,[rsp+120]
       ja        near ptr M01_L66
       mov       r9,[rsp+118]
       mov       r8d,edx
       lea       r9,[r9+r8*2]
       mov       r8d,[rsp+120]
       sub       r8d,edx
       xor       edx,edx
       mov       [rsp+70],r9
       mov       [rsp+78],r8d
       mov       [rsp+60],rdx
       xor       edx,edx
       mov       [rsp+68],edx
       mov       rdx,[rsp+100]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+70]
       lea       r9,[rsp+60]
       lea       r8,[rsp+0B0]
       mov       r11,7FFC913E0550
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L44
       mov       ecx,[rsp+110]
       add       ecx,[rsp+0B0]
       mov       [rsp+110],ecx
       jmp       near ptr M01_L16
M01_L46:
       lea       rcx,[rsp+100]
       mov       rdx,24C80208728
       call      qword ptr [7FFC916558F0]
       jmp       near ptr M01_L17
M01_L47:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+8C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+8C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L48
       call      qword ptr [7FFC91A7C600]
       mov       edx,eax
       jmp       short M01_L49
M01_L48:
       mov       edx,ecx
       sar       edx,10
M01_L49:
       mov       [rsp+90],edx
M01_L50:
       mov       rcx,7FFC91465120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+90]
       xor       edx,edx
       div       dword ptr [7FFC91465C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L57
M01_L51:
       cmp       eax,[r8+8]
       jae       near ptr M01_L68
       mov       [rsp+98],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+30],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+88],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+84],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L53
       test      r10d,r10d
       jne       short M01_L54
       xor       edx,edx
       mov       [rax+14],edx
M01_L52:
       movsxd    rdx,r10d
       mov       r8,[rsp+40]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+84]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+88],1
M01_L53:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+88]
       test      ecx,ecx
       je        short M01_L55
       mov       r8d,1
       jmp       short M01_L58
M01_L54:
       jmp       short M01_L52
M01_L55:
       mov       eax,[rsp+98]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rsp+38]
       cmp       [rcx+8],r8d
       jne       short M01_L56
       xor       r8d,r8d
M01_L56:
       mov       edx,[rsp+94]
       inc       edx
       mov       eax,r8d
M01_L57:
       mov       r8,[rsp+38]
       mov       [rsp+94],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L51
       xor       r8d,r8d
M01_L58:
       mov       eax,r8d
       mov       [rsp+0A8],eax
       mov       eax,[rsp+0AC]
       jmp       near ptr M01_L19
M01_L59:
       mov       edx,eax
       mov       r8,r10
       mov       eax,[rsp+0A8]
       cmp       dword ptr [r12+8],0
       mov       [rsp+0AC],edx
       mov       [rsp+58],r8
       mov       [rsp+0A8],eax
       je        near ptr M01_L20
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A4],eax
       mov       edx,[r12+8]
       mov       [rsp+0A0],edx
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+58]
       mov       r8d,[rsp+0A4]
       mov       r9d,[rsp+0A0]
       mov       edx,3
       call      qword ptr [7FFC915D7690]
       mov       eax,[rsp+0AC]
       test      [rsp+0A8],eax
       mov       [rsp+0AC],eax
       jne       near ptr M01_L20
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rsp+58]
       mov       [rsp+50],rdx
       mov       [rsp+9C],eax
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[rsp+0AC]
       test      r13d,r13d
       jne       short M01_L60
       mov       r14,[rsp+50]
       mov       edx,[rsp+9C]
       mov       ecx,0FFFFFFFF
       jmp       short M01_L61
M01_L60:
       mov       rdx,[rsp+50]
       mov       ecx,[rsp+9C]
       mov       r8d,ecx
       mov       ecx,r14d
       mov       r14,rdx
       mov       edx,r8d
M01_L61:
       mov       r8d,r12d
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L62
       mov       eax,1
       jmp       short M01_L63
M01_L62:
       xor       eax,eax
M01_L63:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFC916FE2B0]
       jmp       near ptr M01_L20
M01_L64:
       mov       rcx,rdi
       call      qword ptr [7FFC915DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L21
M01_L65:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC9193E6D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC9152F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L66:
       call      qword ptr [7FFC916CE9D0]
       int       3
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFC91A44AE0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFC913D4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC9152F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3341
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ObjectMapperBenchmarks.NewtonsoftSingleProperty()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       call      qword ptr [7FFC919369D0]; Newtonsoft.Json.JsonSerializer.CreateDefault()
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC91934420]; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; Newtonsoft.Json.JsonSerializer.CreateDefault()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rcx,2B8F4804E38
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFC91936988]; Newtonsoft.Json.JsonSerializer..ctor()
       test      rbx,rbx
       jne       short M01_L03
M01_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFC91936A00]
       jmp       short M01_L01
; Total bytes of code 94
```
```assembly
; Newtonsoft.Json.JsonConvert.SerializeObjectInternal(System.Object, System.Type, Newtonsoft.Json.JsonSerializer)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       edx,100
       mov       dword ptr [r14+20],7FFFFFFF
       cmp       edx,400
       jl        near ptr M02_L04
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M02_L00:
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2B8F4800428
       mov       r13,[rcx]
       mov       rcx,2B8F48014E8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2B880201C08
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],1
       mov       [rbp-38],r15
       mov       rcx,offset MT_Newtonsoft.Json.JsonTextWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       [r14+24],ecx
       mov       dword ptr [r14+2C],3
       mov       byte ptr [r14+38],1
       mov       byte ptr [r14+39],1
       lea       rcx,[r14+58]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       word ptr [r14+8E],22
       mov       byte ptr [r14+91],1
       mov       word ptr [r14+8C],20
       mov       dword ptr [r14+88],2
       mov       ecx,[r14+30]
       mov       rdx,2B8F4805028
       mov       rax,2B8F4805030
       cmp       ecx,2
       mov       rdx,[rdx]
       cmove     rdx,[rax]
       lea       rcx,[r14+68]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+90],1
       mov       [rbp-40],r14
       mov       rcx,offset MT_Newtonsoft.Json.JsonSerializer
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       r13d,[rbx+94]
       jmp       short M02_L03
M02_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,146
       mov       rdx,7FFC9190A510
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC915CD458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+18]
       mov       r13d,eax
M02_L03:
       test      r13d,r13d
       jl        short M02_L01
       cmp       r13d,1
       jg        short M02_L01
       mov       [r14+24],r13d
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rax,[rbx]
       mov       rax,[rax+80]
       call      qword ptr [rax+18]
       nop
       mov       rcx,rsp
       call      M02_L05
       nop
       mov       r15,[rbp-38]
       mov       rcx,[r15+20]
       cmp       [rcx],ecx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFC9175A088]; System.Text.StringBuilder.ToString()
M02_L04:
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M02_L00
M02_L05:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],8
       je        near ptr M02_L15
       cmp       byte ptr [r14+39],0
       je        short M02_L11
       jmp       short M02_L07
M02_L06:
       mov       edx,[r14+48]
       mov       rcx,r14
       call      qword ptr [7FFC9193EB50]
M02_L07:
       mov       rax,[r14+8]
       test      rax,rax
       jne       short M02_L08
       xor       r15d,r15d
       jmp       short M02_L09
M02_L08:
       mov       ecx,[rax+10]
       mov       r15d,ecx
M02_L09:
       cmp       dword ptr [r14+48],0
       je        short M02_L10
       inc       r15d
M02_L10:
       test      r15d,r15d
       jg        short M02_L06
M02_L11:
       mov       rdx,[r14+70]
       test      rdx,rdx
       je        short M02_L13
       mov       rcx,[r14+78]
       test      rcx,rcx
       je        short M02_L12
       mov       r11,7FFC913D0B88
       call      qword ptr [r11]
M02_L12:
       xor       ecx,ecx
       mov       [r14+70],rcx
M02_L13:
       cmp       byte ptr [r14+38],0
       je        short M02_L15
       mov       rcx,[r14+58]
       test      rcx,rcx
       je        short M02_L15
       mov       rax,offset MT_System.IO.StringWriter
       cmp       [rcx],rax
       jne       short M02_L14
       mov       byte ptr [rcx+28],0
       jmp       short M02_L15
M02_L14:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
M02_L15:
       mov       rcx,r14
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 774
```

## .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
```assembly
; Ferris.Json.Benchmark.ObjectMapperBenchmarks.TextJsonSingleProperty()
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rax,[rcx+8]
       mov       [rsp+40],rax
       call      qword ptr [7FFC91934F18]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rbx,rax
       cmp       byte ptr [rbx+9E],0
       je        short M00_L03
M00_L00:
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L04
       mov       rdx,[rsi+0B8]
       mov       r8,20580308728
       cmp       rdx,r8
       jne       short M00_L04
M00_L01:
       mov       rdx,rsi
       mov       r8,rdx
       test      r8,r8
       je        short M00_L02
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[Ferris.Json.Test.TestObjects.SinglePropertyTest, Ferris.Json.Test]]
       cmp       [r8],rcx
       jne       short M00_L05
M00_L02:
       lea       rdx,[rsp+40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[Ferris.Json.Test.TestObjects.SinglePropertyTest, Ferris.Json.Test]](Ferris.Json.Test.TestObjects.SinglePropertyTest ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<Ferris.Json.Test.TestObjects.SinglePropertyTest>)
       call      qword ptr [7FFC91936B08]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M00_L03:
       mov       rcx,rbx
       call      qword ptr [7FFC91935548]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       short M00_L00
M00_L04:
       mov       byte ptr [rsp+38],1
       mov       byte ptr [rsp+39],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+38]
       mov       rdx,20580308728
       mov       r8d,1
       call      qword ptr [7FFC91934DF8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L05:
       call      qword ptr [7FFC915143F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 208
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,20597404EF8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,20597404EF8
       xor       edx,edx
       jmp       qword ptr [7FFC919355F0]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFC919355C0]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M02_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M02_L12
M02_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M02_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,20597401F00
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFC91AB44D0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M02_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M02_L02
M02_L01:
       mov       edx,2
M02_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M02_L13
       mov       rdi,20580301C08
M02_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M02_L14
M02_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFC919368C8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M02_L08
       cmp       [rcx+8],r15d
       jb        short M02_L07
M02_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M02_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M02_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M02_L06:
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M02_L07
       mov       r12d,r15d
       jmp       short M02_L10
M02_L07:
       call      qword ptr [7FFC916AE9D0]
       int       3
M02_L08:
       test      r15d,r15d
       jne       short M02_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M02_L05
M02_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M02_L06
M02_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFC9193D110]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M02_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M02_L00
M02_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFC91AA7570]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L00
M02_L13:
       mov       rcx,7FFC9190C028
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20597404F38
       mov       rdi,[rcx]
       jmp       near ptr M02_L03
M02_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFC91AA4AE0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M02_L04
M02_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFC91AA7078]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFC91AA4C60]
       mov       r14,r13
       jmp       near ptr M02_L04
M02_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        short M02_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L18
M02_L17:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L19
M02_L18:
       mov       rax,[rcx]
       add       rax,10
M02_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M02_L20
       test      r10d,r10d
       jne       short M02_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M02_L23
M02_L20:
       cmp       [rcx+8],r10d
       jae       short M02_L22
M02_L21:
       call      qword ptr [7FFC916AE9D0]
       int       3
M02_L22:
       add       rcx,10
M02_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M02_L25
       cmp       rdx,300
       ja        short M02_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M02_L25
M02_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFC915C5BA8]
M02_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,20597401F00
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFC91AB44D8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1184
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M03_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M03_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFC91934390]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M03_L05
       call      qword ptr [7FFC91937120]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFC91514360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M03_L03
       jmp       near ptr M03_L09
M03_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L09
M03_L03:
       call      qword ptr [7FFC91937330]
       test      eax,eax
       je        near ptr M03_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFC919D4450]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFC919D4450]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFC919D4480]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFC919371F8]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC919D4318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC919D4318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC919D4318]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFC91935548]
       jmp       short M03_L09
M03_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFC919D4390]
       jmp       short M03_L09
M03_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFC91514360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L07
M03_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M03_L08
M03_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M03_L08:
       cmp       dword ptr [rbp-34],0
       je        short M03_L09
       call      qword ptr [7FFC9193C180]
M03_L09:
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
       call      qword ptr [7FFC91935500]; System.Text.Json.JsonSerializerOptions.get_IsReadOnly()
       test      eax,eax
       je        short M04_L00
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC91934DB0]; System.Text.Json.JsonSerializerOptions.get_CacheContext()
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       r8d,[rbp+38]
       movzx     r8d,r8b
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFC919D4360]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddTypeInfo(System.Type, Boolean)
       mov       [rbp-8],rax
       mov       ecx,[rbp+20]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M04_L01
       cmp       qword ptr [rbp-8],0
       je        short M04_L01
       mov       rcx,[rbp-8]
       call      qword ptr [7FFC919361D8]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.EnsureConfigured()
       jmp       short M04_L01
M04_L00:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M04_L01
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFC91935560]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       [rbp-8],rax
M04_L01:
       cmp       qword ptr [rbp-8],0
       jne       short M04_L02
       lea       rcx,[rbp+28]
       call      qword ptr [7FFC917D4720]; System.Nullable`1[[System.Boolean, System.Private.CoreLib]].GetValueOrDefault()
       test      eax,eax
       je        short M04_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFC91934FC0]; System.Text.Json.JsonSerializerOptions.get_TypeInfoResolver()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+18]
       call      qword ptr [7FFC9193C768]
M04_L02:
       mov       rax,[rbp-8]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 219
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M05_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M05_L02
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L01
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L01
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L01
       test      rax,rax
       jne       short M05_L00
M05_L03:
       lea       rax,[7FFCF0EDB908]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

